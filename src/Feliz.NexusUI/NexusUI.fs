namespace Feliz

open Feliz
open Fable.Core
open Fable.Core.JsInterop
open Feliz.NexusUIReact

[<Erase>]
type NexusUI =
  static member inline button(properties: IButtonProperty seq) = Interop.reactApi.createElement (import "Button" "react-nexusui", createObj !!properties)
  static member inline toggle(properties: IToggleProperty seq) = Interop.reactApi.createElement (import "Toggle" "react-nexusui", createObj !!properties)
  static member inline dial(properties: IDialProperty seq) = Interop.reactApi.createElement (import "Dial" "react-nexusui", createObj !!properties)
  static member inline number(properties: INumberProperty seq) = Interop.reactApi.createElement (import "Number" "react-nexusui", createObj !!properties)
  static member inline position(properties: IPositionProperty seq) = Interop.reactApi.createElement (import "Position" "react-nexusui", createObj !!properties)
  static member inline slider(properties: ISliderProperty seq) = Interop.reactApi.createElement (import "Slider" "react-nexusui", createObj !!properties)
  static member inline envelope(properties: IEnvelopeProperty seq) = Interop.reactApi.createElement (import "Envelope" "react-nexusui", createObj !!properties)
  static member inline mutliSlider(properties: IMultisliderProperty seq) = Interop.reactApi.createElement (import "Multislider" "react-nexusui", createObj !!properties)
  static member inline piano(properties: IPianoProperty seq) = Interop.reactApi.createElement (import "Piano" "react-nexusui", createObj !!properties)
  static member inline radioButton(properties: IRadioButtonProperty seq) = Interop.reactApi.createElement (import "RadioButton" "react-nexusui", createObj !!properties)
  static member inline select(properties: ISelectProperty seq) = Interop.reactApi.createElement (import "Select" "react-nexusui", createObj !!properties)
  static member inline sequencer(properties: ISequencerProperty seq) = Interop.reactApi.createElement (import "Sequencer" "react-nexusui", createObj !!properties)
  static member inline textButton(properties: ITextButtonProperty seq) = Interop.reactApi.createElement (import "TextButton" "react-nexusui", createObj !!properties)
  static member inline tilt(properties: ITiltProperty seq) = Interop.reactApi.createElement (import "Tilt" "react-nexusui", createObj !!properties)
  static member inline pan(properties: IPanProperty seq) = Interop.reactApi.createElement (import "Pan" "react-nexusui", createObj !!properties)
  static member inline pan2d(properties: IPan2DProperty seq) = Interop.reactApi.createElement (import "Pan2D" "react-nexusui", createObj !!properties)
  