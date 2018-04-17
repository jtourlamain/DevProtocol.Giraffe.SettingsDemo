module DevProtocol.Giraffe.SettingsDemo.Web.Routing

open Giraffe
open DevProtocol.Giraffe.SettingsDemo.Web.HttpHandlers

//let webApp =
let routes: HttpFunc -> HttpFunc =
    choose [
        GET >=>
            choose [
                route "/" >=> indexHandler "world"
                routef "/hello/%s" indexHandler
            ]
        setStatusCode 404 >=> text "Not Found" ]
