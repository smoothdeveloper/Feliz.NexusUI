namespace Feliz.NexusUIReact

open Fable.Core

[<Erase>]
type toggle =
    static member inline size(size: Size) = Interop.mkToggleAttr "size" size
    static member inline state(state: bool) = Interop.mkToggleAttr "state" state
    static member inline onChange(onChange: bool -> unit) = Interop.mkToggleAttr "onChange" onChange
    static member inline onReady(onReady: Nexus.Toggle -> unit) = Interop.mkToggleAttr "onReady" onReady
