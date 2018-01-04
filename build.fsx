#r "packages/build/FAKE/tools/FakeLib.dll"
#r "System.IO.Compression.FileSystem"
#load "paket-files/build/fable-compiler/fake-helpers/Fable.FakeHelpers.fs"

open Fake
open Fable.FakeHelpers

let packages = [
  "Rebass/Fable.Rebass"
]

#if MONO
// prevent incorrect output encoding (e.g. https://github.com/fsharp/FAKE/issues/1196)
System.Console.OutputEncoding <- System.Text.Encoding.UTF8
#endif

let dotnetcliVersion = "2.0.3"
let mutable dotnetExePath = environVarOrDefault "DOTNET" "dotnet"

// Clean and install dotnet SDK
Target "Bootstrap" (fun () ->
  !! "**/bin" ++ "**/obj" |> CleanDirs
  dotnetExePath <- DotNetCli.InstallDotNetSDK dotnetcliVersion
)

Target "PublishPackages" (fun () ->
  packages
  |> List.map (fun p -> p + ".fsproj")
  |> publishPackages __SOURCE_DIRECTORY__ dotnetExePath
)

"Bootstrap"
==> "PublishPackages"

RunTargetOrDefault "Bootstrap"
