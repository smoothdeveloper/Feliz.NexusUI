namespace Feliz.NexusUIReact

open Fable.Core

[<StringEnum>] 
type ButtonMode =
  | Button
  | Aftertouch
  | Impulse
  | Toggle
  
[<Erase>]
type button =
  static member inline size(size: Size) = Interop.mkButtonAttr "size" size
  static member inline mode(mode: ButtonMode) = Interop.mkButtonAttr "mode" mode
  static member inline state(state: bool) = Interop.mkButtonAttr "state" state
  static member inline state(state: int) = Interop.mkButtonAttr "state" state
  static member inline onChange(onChange: bool -> unit) = Interop.mkButtonAttr "onChange" onChange
  static member inline onChange(onChange: int -> unit) = Interop.mkButtonAttr "onChange" onChange
  static member inline onReady(onReady: Nexus.Button -> unit) = Interop.mkButtonAttr "onReady" onReady
