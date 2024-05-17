namespace Feliz.NexusUIReact
open Fable.Core
[<Erase>]
type envelope =
    static member inline size(size: Size) = Interop.mkEnvelopeAttr "size" size
    static member inline noNewPoints(noNewPoints: bool) = Interop.mkEnvelopeAttr "noNewPoints" noNewPoints
    //static member inline points(points: {| x:int; y:int |} array) = Interop.mkEnvelopeAttr "points" points
    static member inline points(points: {| x:float; y:float |} array) = Interop.mkEnvelopeAttr "points" points
    //static member inline onChange(onChange: {| x:int; y:int |} array -> unit) = Interop.mkEnvelopeAttr "onChange" onChange
    static member inline onChange(onChange: {| x:float; y:float |} array -> unit) = Interop.mkEnvelopeAttr "onChange" onChange
    static member inline onReady(onReady: Nexus.Envelope-> unit) = Interop.mkEnvelopeAttr "onReady" onReady
    