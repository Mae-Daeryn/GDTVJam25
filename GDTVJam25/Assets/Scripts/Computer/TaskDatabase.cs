using System.Collections.Generic;
using UnityEngine.SocialPlatforms.Impl;

public static class TaskDatabase
{
    public static List<Task> All = new List<Task>
    {
        new Task
        {
            subject = "Bearded Dragon Terra build",
            sender = "Margaret",
            sendermail = "noIdeaWhatToPutHere@gmail.com",
            mailContent = "Hiii,\n" +
            "I need a Tank for a Bearded Dragon.\n" +
            "Thanks,\n" +
            "Margaret",
            description = "Build a Desert Terrarium for a Bearded Dragon",
            type = DragDrop.terraType.desert,
            requiredScore = 25
        },
        new Task
        {
            subject = "Frog-Terrarium",
            sender = "froglover69",
            sendermail = "froglover69@froggystyle.de",
            mailContent = "Dear Terra-Building,\n" +
            "pls make me a Frog Tank.\n" +
            "Best Regards,\n" +
            "FrogLover from FroggyStyle",
            description = "Rainforest ambience with lots of humidity and plants",
            type = DragDrop.terraType.rainforest,
            requiredScore = 25
        }
    };

    public static Task currentTask;
    public static List<Task> ReturnAll()
    {
        return All;
    }

    public static void RemoveTask(Task task)
    {
        All.Remove(task);
    }
}
