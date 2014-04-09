// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

open System;
open Tesseract;
open System.Drawing;
open System.Diagnostics;


[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    let testImagePath =
        if argv.Length > 0 then argv.[0]
        else  "C:\GitHub\Tesseract.FSharpSamples\Tesseract.FSharpSamples.ConsoleApp\cisla.png"

    use engine = new TesseractEngine(@"C:\GitHub\Tesseract.FSharpSamples\Tesseract.FSharpSamples.ConsoleApp\tessdata", "eng", EngineMode.Default)
    use img = Pix.LoadFromFile(testImagePath)
    use page = engine.Process(img)
    let text = page.GetText()
    printfn "%A" text
        

    0 // return an integer exit code
