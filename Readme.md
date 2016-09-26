# Client Callback

This is an example solution show you how you can create a simple self-hosted application for accepting and handling callbacks from
the FormFree Webhook API.

As of this writing of this example there is only one webhook. It will callback to the URL you provided in your VodRequest with
the following HTTP POST parameters:

1. VOD_ID
   * This is the id of the VodRequest that the webhook is reporting about. This is a `Guid` value is always provided.
2. OrderStatus
   * This is the status of the VodRequest. It is an `int` value in C# and is always provided.
3. ReportID
   * This is a optional report id that is provided if the webhook is calling back about a report generation. In the event
   the value exists it is a `Guid`.

### No Self-Hosting

You may not want to self-host in such a case you will only be interested in the CallbackServer/Controller/CallbackController.cs file.
It contains the definition of 1) a WebAPI controller method to handle the post, and 2) the a model class describing the
post body.

### Self-Hosting

If you are interested in self-hosting (i.e. having a console application with an embedded web server), you can look at
the following Microsoft provided [documentation](1). The CallbackServer/Program.cs contains a basic HTTP setup.

[1]: http://www.asp.net/web-api/overview/hosting-aspnet-web-api/use-owin-to-self-host-web-api