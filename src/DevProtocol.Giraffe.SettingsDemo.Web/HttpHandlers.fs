module DevProtocol.Giraffe.SettingsDemo.Web.HttpHandlers

open Microsoft.AspNetCore.Http
open Microsoft.Extensions.Configuration
open Giraffe
open Giraffe.Razor
open DevProtocol.Giraffe.SettingsDemo.Web.Models


let indexHandler =
    fun (next: HttpFunc) (ctx: HttpContext) ->
        let settings = ctx.GetService<IConfiguration>()
        let model     = { Text = "Giraffe demo: " + settings.["Greeting"] }
        razorHtmlView "Index" model next ctx