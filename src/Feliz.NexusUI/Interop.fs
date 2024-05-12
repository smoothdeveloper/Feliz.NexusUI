namespace Feliz.NexusUIReact
open Fable.Core
module Nexus =
  type Button = obj
  type Toggle = obj
  type Dial = obj
  type Number = obj
  type Position = obj
  type Slider = obj
  type Envelope = obj
  type Multislider = obj
  type Piano = obj
  type RadioButton = obj
  type Select = obj
  type Sequencer = obj
  type TextButton = obj
  type Tilt = obj
  type Pan = obj
  type Pan2D = obj
type Size = int * int
[<Erase; RequireQualifiedAccess>]
module Interop =
  let inline mkButtonAttr (key: string) (value: obj) : IButtonProperty = unbox (key, value)
  let inline mkToggleAttr (key: string) (value: obj) : IToggleProperty = unbox (key, value)
  let inline mkDialAttr (key: string) (value: obj) : IDialProperty = unbox (key, value)
  let inline mkNumberAttr (key: string) (value: obj) : INumberProperty = unbox (key, value)
  let inline mkPositionAttr (key: string) (value: obj) : IPositionProperty = unbox (key, value)
  let inline mkSliderAttr (key: string) (value: obj) : ISliderProperty = unbox (key, value)
  let inline mkEnvelopeAttr (key: string) (value: obj) : IEnvelopeProperty = unbox (key, value)
  let inline mkMultisliderAttr (key: string) (value: obj) : IMultisliderProperty = unbox (key, value)
  let inline mkPianoAttr (key: string) (value: obj) : IPianoProperty = unbox (key, value)
  let inline mkRadioButtonAttr (key: string) (value: obj) : IRadioButtonProperty = unbox (key, value)
  let inline mkSelectAttr (key: string) (value: obj) : ISelectProperty = unbox (key, value)
  let inline mkSequencerAttr (key: string) (value: obj) : ISequencerProperty = unbox (key, value)
  let inline mkTextButtonAttr (key: string) (value: obj) : ITextButtonProperty = unbox (key, value)
  let inline mkTiltAttr (key: string) (value: obj) : ITiltProperty = unbox (key, value)
  let inline mkPanAttr (key: string) (value: obj) : IPanProperty = unbox (key, value)
  let inline mkPan2DAttr (key: string) (value: obj) : IPan2DProperty = unbox (key, value)