using System.Collections.Generic;

public static class TaskDatabase
{
    public static List<Task> All = new List<Task>
    {
        new Task
        {
            title = "Gecko-Terrarium",
            shortDescription = "A desert terrarium for a Gecko.",
            // shortDescription = "Ein Wüsten-Terrarium für einen Gecko.",
            // description = "Ein Kunde möchte ein Terrarium für einen Gecko mit 2 Wüstenpflanzen und 1 Wärmelampe.",
            description = "A customer wants to build a terrarium for a gecko. He wants to have at least 1 desert plant and 1 heat lamp",
            type = TerrariumType.Desert,
            criteria = new List<string> { "2 Desert plants", "1 Heat lamp" },
            criteriaOptional = new List<string> { "Deko: Skull", "Desert stone" }
        },
        new Task
        {
            title = "Frog-Terrarium",
            // shortDescription = "Ein Regenwald-Terrarium für Frösche.",
            shortDescription = "A rainforest terrarium for frogs.",
            // description = "Regenwald-Stimmung mit viel Feuchtigkeit und Pflanzen.",
            description = "Rainforest ambience with lots of humidity and plants",
            type = TerrariumType.Rainforest,
            criteria = new List<string> { "2 Rainforest plants", "1 Smoke machine" },
            criteriaOptional = new List<string> { "Moss", "Background picture" }
        }
    };
}
