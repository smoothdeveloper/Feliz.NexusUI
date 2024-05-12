namespace Feliz.NexusUIReact
open Fable.Core

[<StringEnum>]
type DialInteraction =
  | Radial
  | Vertical
  | Horizontal
  
[<StringEnum>]
type DialMode =
  | Absolute
  | Relative
  
[<Erase>]
type dial =
  static member inline interaction(interaction: DialInteraction) = Interop.mkDialAttr "interaction" interaction
  static member inline mode(mode: DialMode) = Interop.mkDialAttr "mode" mode
  static member inline min(min: int) = Interop.mkDialAttr "min" min
  static member inline max(max: int) = Interop.mkDialAttr "max" max
  static member inline step(step: int) = Interop.mkDialAttr "step" step
  static member inline value(value: int) = Interop.mkDialAttr "value" value
  static member inline onChange(onChange: int -> unit) = Interop.mkDialAttr "onChange" onChange
  static member inline onReady(onReady: Nexus.Dial -> unit) = Interop.mkDialAttr "onReady" onReady

