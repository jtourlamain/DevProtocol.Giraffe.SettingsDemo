module DevProtocol.Giraffe.SettingsDemo.Web.HttpHandlers

open Giraffe
open Giraffe.Razor
open DevProtocol.Giraffe.SettingsDemo.Web.Models


let indexHandler (name : string) =
    let greetings = sprintf "Hello %s, from Giraffe!" name
    let model     = { Text = greetings }
    razorHtmlView "Index" model