using System.Collections.Generic;

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
            description = "A customer wants to build a terrarium for a Bearded Dragon. He wants to have at least 1 desert plant and 1 heat lamp",
            type = DragDrop.terraType.desert,
            criteria = new List<string> { "2 Desert plants", "1 Heat lamp" },
            criteriaOptional = new List<string> { "Deko: Skull", "Desert stone" }
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
            criteria = new List<string> { "2 Rainforest plants", "1 Smoke machine" },
            criteriaOptional = new List<string> { "Moss", "Background picture" }
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
