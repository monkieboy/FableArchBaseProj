#r "node_modules/fable-core/Fable.Core.dll"
#r "node_modules/fable-arch/Fable.Arch.dll"

open Fable.Arch
open Fable.Arch.App
open Fable.Arch.App.AppApi
open Fable.Arch.Html

type Model = string

let Initial = ""

type Actions = A | B

let update model =
    function
    | A _ -> "A"
    | B _ -> "B"

let view (model:Model) =
    div
        [ ]
        [ text "Hello" ]

createSimpleApp Initial view update Virtualdom.createRender
|> withStartNodeSelector "#app"
|> start
