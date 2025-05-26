using System.Collections.Generic;
using System.Linq;

public static class TaskDatabase
{

    public static List<Task> All = new()
    {
        new Task
        {
            subject = "Betta Fish Tank",
            sender = "Kungfu Sandra",
            sendermail = "Kungfu Sandra",
            mailContent = @"Dear Terra-Building,

my name is Sandra and I always dreamed of owning my own Fish Tank! HIYAHHH! Of course I love Betta fish the most. My Betta is called Goku and he cost over 9000 $! He should be in the spotlight. 
I want it to look like an arena or something like that! Can you do that?!
Alright! Fist on it!

Kungfu Sandra",
            description = "Build a fish tank for little Goku",
            type = DragDrop.terraType.water,
            requiredScore = 25
        },
        new Task
        {
            subject = "Day Gecko!!!!",
            sender = "Kenny",
            sendermail = "TheSurvivor.Kenny06@weirddomain.com",
            mailContent = @"Terra-Build! It's me! It's Kenny!!

I've got an super important request for you!
Please make me a terrarium for my Day Gecko (she seems to be shy, but I'm 101% sure that she's just pretending to be shy).
It should be awesome to have different layers of plants which provide enough cover (she's watching me sometimes. I don't know why. Maybe she's some kind of supernatural being?!).
However, everything is fine (No it's not! Please make it a steady terrarium)!

Despaired regards from KENNY!!!!",
            description = "Build a rainforest terrarium for a Day Gecko",
            type = DragDrop.terraType.rainforest,
            requiredScore = 25
        },
        new Task
        {
            subject = "Tree Frogs are sooo sweeet!",
            sender = "Mary",
            sendermail = "kawaii.uwu@love2u.com",
            mailContent = @"Hiii~ hiii~, Terra-Build!

My name is Mary and I loooove frogs!
Omg, they're so adorable! <3
I mean, look at their cutie cute blobby eyes and their smol wiggly butty butt! UwU
I always wanted to have a super sweet and colourful terrarium with lots of froggos in it! And then I saw that advertisement of yours. FR, I was like: O M G! That's exactly what I need! Will you make a pretty home for my beloved Tree Frogs pleeeaaaase?

Lovely regards,
Mary ^-^",
            description = "Build a rainforest terrarium for Frogs",
            type = DragDrop.terraType.rainforest,
            requiredScore = 25
        },
        new Task
        {
            subject = "Chameleon Terrarium",
            sender = "Jody",
            sendermail = "name.anothername99@anonymous.net",
            mailContent = @"Hello.

I've got a Chameleon. I only care for a good environment within the terrarium. I don't care what it looks like as long as the Chameleon will feel safe and well. That's it.

Jody",
            description = "Build a rainforest Terrarium for a Chameleon",
            type = DragDrop.terraType.rainforest,
            requiredScore = 25
        },
        new Task
        {
            subject = "Chillin cool terra",
            sender = "Diego",
            sendermail = "manly.man@coolcaps.nice",
            mailContent = @"Yoo, wazzup Daeryns!

The name's Diego. I've got the coolest Sand Boa around. Her name is Buffy. Check zis pic out: [snake.png.fileerror]
Anyways, I'm too cool for random stuff. Make it look gangster-like! Skulls, bones or dangerous looking plants and so on. You got me?

Cya bro!
",
            description = "Build a \"dangerous\" looking Terrarium for a Sand Boa",
            type = DragDrop.terraType.rainforest,
            requiredScore = 25
        },
        new Task
        {
            subject = "フトアゴヒゲトカゲ",
            sender = "正田崇弘義",
            sendermail = "正田崇.弘義@ケーキ国.jp",
            mailContent = @"こんにちは、親愛なる会社様。アゴヒゲトカゲ用のテラリウムが必要です。見た目をきれいに整えてもらえますか？予算は関係ありません。      どうもありがとう。
心から、
正田崇弘義

Translation by noodle translate:
Good day, fighting office. I need a terrarium for a beard in a game. Please make it look correct and visible. Many coins don't play a role. Thank you!
Until we meet again,
Name",
            description = "Not sure what the customer wants... Just build a desert Terrarium",
            type = DragDrop.terraType.desert,
            requiredScore = 25
        },
        new Task
        {
            subject = "Job",
            sender = "Sir Brown",
            sendermail = "sirbrown.important@rich.money",
            mailContent = @"Greetings, fellow workers of the adressed company.

I am Sir Brown of Whippersnapper, an extremely rich and important person. I shall grant you the privilege to commit a design for my bejewled terrarium. My most honored Desert Tortoise, Sir Toir le Toise, demands an adequate interior design. If thy shall succeed on this noble quest of mine, wealth will be upon you.
Wealthy regards,

Sir Brown of Whippersnapper",
            description = "Build a Desert Terrarium for the Tortoise 'Sir Toir le Toise' from Sir Brown",
            type = DragDrop.terraType.rainforest,
            requiredScore = 25
        }
    };

    private static readonly Task[] AllCopied;
    static TaskDatabase()
    {
        AllCopied = new Task[All.Count];
        All.CopyTo(AllCopied);
    }

    public static Task currentTask;
    public static List<Task> ReturnAll()
    {
        return All;
    }

    public static void RemoveTask(Task task)
    {
        All.Remove(task);
        if (All.Count == 0) All = AllCopied.ToList();
    }
}
