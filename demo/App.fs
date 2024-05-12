namespace demo

open Fable.Import
open Feliz
open Feliz.NexusUIReact

type Widgets =
  static member TitleAndChildren (title: string) children =
    Html.div [
      prop.style [style.margin 10]
      prop.children [
        Html.h2 [prop.className "subtitle"; prop.text title]
        yield! children
      ]
    ]

type Groups =
  static let makeGroup (title:string) (children: _ seq) =
    Html.section [
      prop.className "section"
      prop.children [
        Html.div [
          prop.className "container"
          prop.children [
            Html.h2 [prop.className "title"; prop.text title]
            Html.div [
              prop.style [style.display.flex; style.flexWrap.wrap]
              prop.children children
            ]
          ]
        ]
      ]
    ]
  
  [<ReactComponent>]
  static member Core () =
    makeGroup
      "Core"
      [
        Widgets.TitleAndChildren
          "Toggle"
          [
            NexusUI.toggle [
              toggle.size (100,30)
              toggle.state false
            ]
          ]
        Widgets.TitleAndChildren
          "Button"
          [
            NexusUI.button [
              button.size (100,30)
              button.mode Button
              button.state false
            ]
          ]
        Widgets.TitleAndChildren
          "Dial"
          [
            NexusUI.dial [
              dial.interaction Radial
              dial.onChange (fun v -> Browser.Dom.console.log v)
              dial.value 8
              dial.step 1
              dial.min 0
              dial.max 10
            ]
          ]
        Widgets.TitleAndChildren
          "Number"
          [
            NexusUI.number [
              number.step 1
              number.min 0
              number.max 10
              number.value 4
            ]
          ]
        (*  
        Widgets.TitleAndChildren
          "Position"
          [
            NexusUI.position [
              position.onChange Browser.Dom.console.log
            ]
          ]
          *)
      ]
type App =
  static member App() =
    React.fragment [
      Groups.Core ()
    ]
    
module Main =    
  let root =
    Browser.Dom.document.getElementById "app"
    |> ReactDOM.createRoot
  root.render (App.App())