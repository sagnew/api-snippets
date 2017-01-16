// Download the twilio-csharp library from
// https://www.twilio.com/docs/libraries/csharp#installation
using System;
using Twilio;
using Twilio.Rest.Taskrouter.V1.Workspace;

class Example
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Auth Token at twilio.com/console
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";
        const string workspaceSid = "WSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string taskQueueSid = "WQf855e98ad280d0a0a325628e24ca9627";

        TwilioClient.Init(accountSid, authToken);

        var tasks = TaskResource.Read(workspaceSid, taskQueueSid: taskQueueSid);
        foreach(var task in tasks) {
            Console.WriteLine(task.Attributes);
        }

        var pendingTasks = TaskResource.Read(
            workspaceSid, assignmentStatus: TaskResource.StatusEnum.Pending);
        foreach(var task in pendingTasks) {
            Console.WriteLine(task.Attributes);
        }
    }
}
