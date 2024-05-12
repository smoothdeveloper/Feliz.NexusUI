# Feliz.NexusUI

Feliz style binding for [react-nexusui](https://github.com/rakannimer/react-nexusui)

Here's how it looks:

```fsharp
module App

open Feliz
open Feliz.NexusUIReact

[<ReactComponent>]
let MyComponent () =
  Html.div [
    NexusUI.dial [
      dial.interaction Radial
      dial.onChange (fun v -> Browser.Dom.console.log v)
      dial.value 8
      dial.step 1
      dial.min 0
      dial.max 10
    ]
  ]
```

## Installation

Run `femto install Feliz.NexusUI` from inside your project directory.

## Source code

Found in `./src/Feliz.NexusUI`

## Samples

Samples are found in `./demo`. Samples will align to the samples found in the react-nexusui documentation.

## Contributing

In root folder:
- Run `pnpm install` to install npm packages
- Run `npm run dev` to start the demo application to test changes

## Credits

- [Zaïd Ajaj](https://github.com/Zaid-Ajaj/) for Feliz & more eco-system
- [Rakan Nimer](https://github.com/rakanimmer) for react-nexusui bindings
- [nexuis-js](https://github.com/nexus-js) project contributors
- [fable](https://github.com/fable-compiler/Fable) project contributors
- [Microsoft F#](https://github.com/dotnet/fsharp) project contributors
- [Greg Petrites](https://github.com/GPetrites) for [Feliz.PrimeReact](https://github.com/GPetrites/Feliz.PrimeReact) (binding similar to this project)