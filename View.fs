module FSharpProject.View

open Suave.Html

let index =
    html [] [
        head [] [
            title [] "FSharp Project with Suave"
        ]

        body [] [
            div ["id", "header"] [
                tag "h1" [] [
                    a "/" [] [Text "F# Suave Music Store"]
                ]
            ]

            div ["id", "footer"] [
                Text "built with "
                a "http://fsharp.org" [] [Text "F#"]
                Text " and "
                a "http://suave.io" [] [Text "Suave.IO"]
            ]
        ]
    ]
    |> htmlToString