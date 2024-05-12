namespace Feliz.NexusUIReact
open Fable.Core
[<Erase>]
type number =
  static member inline size(size: int) = Interop.mkNumberAttr "size" size
  static member inline min(min: int) = Interop.mkNumberAttr "min" min
  static member inline max(max: int) = Interop.mkNumberAttr "max" max
  static member inline step(step: int) = Interop.mkNumberAttr "step" step
  static member inline value(value: int) = Interop.mkNumberAttr "value" value