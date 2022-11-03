using System;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Xml.Serialization;

class Program
{
    public static void Main(string[] args)
    {
        int room = 1; //This keeps track of what room the player is in.
        int californiaGirls = 1800;
        string response = ""; //This keeps track of what the player wants to do
        bool gameFinished = false;
        bool hasCode = false;
        bool wokeup = false;
        bool cratebroken = false;
        bool fireplace = false;
        Random random = new Random();
        int pointfulfillment = random.Next(1, 4);

        //While they are still playing let them type in new responses
        while (gameFinished == false)
        {

            if (wokeup == false)
            {
                Console.WriteLine("[wake up]");

            }
            response = Console.ReadLine();

            if (response.Equals("help"))
            {
                Console.WriteLine("You have one goal. Get through the door.");
            }
            else if (response.Equals("i"))
            {

            }
            else
            {
                switch (room)
                {
                    case 0:
                        if (pointfulfillment == 1)
                        {
                            Console.WriteLine("You died! heres your punishment");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("here's California Girls by Katy Perry");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("I know a place");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Where the grass is really greener");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Warm, wet n' wild");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("There must be something in the water");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Sippin' gin and juice");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Laying underneath the palm trees(Undone)");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("The boys");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Break their necks");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Try'na to creep a little sneak peek(At us)");
                            Console.WriteLine("");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("You could travel the world");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("But nothing comes close");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("To the golden coast");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Once you party with us");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("You'll be falling in love");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Ooh oh ooh oh oh ooh");
                            Console.WriteLine("");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("California girls");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("We're unforgettable");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Daisy dukes");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Bikinis on top");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Sun-kissed skin");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("So hot");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("We'll melt your popsicle");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Ooh oh ooh");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Ooh oh ooh");
                            Console.WriteLine("");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("California girls");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("We're undeniable");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Fine, fresh, fierce");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("We got it on lock");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("West coast represent");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Now put your hands up");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Ooh oh ooh");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Ooh oh ooh");
                            Console.WriteLine("");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("ujh on the beach");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("We don't mind sand in our stilettos");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("We freak");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("In my jeep");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Snoop doggy-dog on the stereo oh oh");
                            Console.WriteLine("");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("You could travel the world");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("But nothing comes close");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("To the golden coast");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Once you party with us");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("You'll be falling in love");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Ooh oh ooh ooh oh ooh");
                            Console.WriteLine("");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("California girls");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("We're unforgettable");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Daisy dukes");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Bikinis on top");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Sun-kissed skin");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("So hot");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("We'll melt your popsicle");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Ooh oh ooh");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Ooh oh ooh");
                            Console.WriteLine("");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("California girls");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("We're undeniable");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Fine, fresh, fierce");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("We got it on lock");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("West coast represent");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Now put your hands up");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Ooh oh ooh");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Ooh oh ooh");
                            Console.WriteLine("");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Toned, tan");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Fit and ready");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Turn it up 'cause its gettin' heavy");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Wild, wild west coast");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("These are the girls I love the most");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("I mean the ones");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("I mean like she's the one");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Kiss her, touch her");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Squeeze her buns");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("The girl's a freak");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("She drive a jeep");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("And live on the beach");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("I'm okay");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("I won't play");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("I love the bay");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Just like I love L.A.");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Venice Beach");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("And Palm Springs");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Summertime is everything");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Home boys");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Bangin' out");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("All that yhg");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Hanging out");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Bikinis, zucchinis, martinis");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("No weenies");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Just a king");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("And a queenie");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Katy my lady(Yeah)");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("And looky here baby(Uh huh)");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("I'm all up on ya");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("'Cause you representing California (oh yeah)");
                            Console.WriteLine("");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("California girls");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("We're unforgettable");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Daisy dukes");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Bikinis on top");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Sun-kissed skin");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("So hot");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("We'll melt your popsicle");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Ooh oh ooh");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Ooh oh ooh");
                            Console.WriteLine("");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("California girls");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("We're undeniable");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Fine, fresh, fierce");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("We got it on lock");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("West coast represent");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Now put your hands up");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Ooh oh ooh");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("Ooh oh ooh");
                            Console.WriteLine("");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("California girls man");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("(California)");
                            Thread.Sleep(californiaGirls);
                            Console.WriteLine("(California girls)");;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("You died! restart");
                        }
                        break;
                    case 1:
                        switch (response)
                        {
                            case "die test":
                                room = 0;
                                break;

                            case "left":
                                if (fireplace == true)
                                {
                                    Console.WriteLine("No point in going here");
                                }
                                else
                                {
                                    Console.WriteLine("It seems the fire is about to go out, put the wood in? [revive fire] or [go back]");
                                    room = 3;
                                }
                                break;

                            case "right":
                                if (hasCode == true)
                                {
                                    Console.WriteLine("The door opens. The shadow seems to hide away out of sight.");
                                    Console.WriteLine("A blinding light, so tempting the curiosity would kill you if you dont go through.");
                                    Console.WriteLine("You look back and see that the door is fading in and out of sight, like some kind of glitch");
                                    Console.WriteLine("[go back] or [continue]");
                                    room = 4;
                                }
                                else
                                {
                                    Console.WriteLine("A shadow from under the door can be seen. Something shuffling around. Look for a code. [go back]");
                                }
                                break;

                            case "go back":
                                Console.WriteLine("You go back.");
                                room = 1;
                                break;

                            case "behind":
                                if (hasCode == true)
                                {
                                    Console.WriteLine("No point in going here.");
                                }
                                else
                                {
                                    Console.WriteLine("An old crate with termite damage and dust all over stands before you. a swift kick could probably break it. [kick]?");
                                    room = 2;
                                }
                                break;

                            case "wake up":
                                Console.WriteLine("You wake up in a strange room, the atmosphere is dark and dreary. To your left is nothing but an old fireplace and some wood.");
                                Console.WriteLine("To your right is a strange steel door with a code.");
                                Console.WriteLine("Behind you is some old crate that can probably be broken with a swift kick");
                                Console.WriteLine("Where would you like to go? Type [left] [right] [behind]");
                                wokeup = true;
                                break;

                            case "look around":
                                Console.WriteLine("To your right is a strange steel door with a code.");
                                if (cratebroken == true)
                                {
                                    Console.WriteLine("Behind you is a broken crate with nothing in it");
                                }
                                else
                                {
                                    Console.WriteLine("Behind you is some old crate that can probably be broken with a swift kick");
                                }
                                break;

                            default:
                                Console.WriteLine("Type something legible");
                                break;
                        }
                        break;
                    case 2:
                        switch (response)
                        {
                            case "kick":
                                Console.WriteLine("You kick the crate and a code pops out. [get code]?");
                                cratebroken = true;
                                break;

                            case "get code":
                                Console.WriteLine("You got the code. [go back]?");
                                hasCode = true;
                                break;

                            case "go back":
                                Console.WriteLine("You go back.");
                                room = 1;
                                break;
                            default:
                                Console.WriteLine("Type something legible");
                                break;
                        }
                        break;
                    case 3:
                        switch (response)
                        {
                            case "revive fire":
                                fireplace = true;
                                Console.WriteLine("The fire is roaring [go back]");
                                break;

                            case "go back":
                                Console.WriteLine("You go back");
                                room = 1;
                                break;

                            default:
                                Console.WriteLine("Type something legible");
                                break;
                        }
                        break;
                    case 4:

                        switch (response)
                        {
                            case "continue":
                                Console.WriteLine("The moment the door fades away you feel a harsh chill.");
                                Thread.Sleep(3500);
                                Console.WriteLine("From where the door used to be, a dark spot appears, you stop in your tracks.");
                                Thread.Sleep(4000);
                                Console.WriteLine("You try to move, it doesnt work.");
                                Thread.Sleep(1500);
                                Console.WriteLine("You try to call for help, it doesnt work");
                                Thread.Sleep(1800);
                                Console.WriteLine("You try to scream, it doesnt work");
                                Thread.Sleep(1500);
                                Console.WriteLine("The darkness overtakes you [press enter]");
                                room = 0;
                                break;

                            case "go back":
                                Console.WriteLine("You decide to go back to the door, the door starts to be clearer, when you feel a sharp chill.");
                                Console.WriteLine("You look behind you and see a dark, humanoid shadow figure at least 10 feet tall seemingly fade into existence.");
                                Console.WriteLine("it starts to move at you, progressively getting faster.");

                                Thread.Sleep(12000);
                                Console.Write("You start to run,");
                                Thread.Sleep(1500);
                                Console.Write(" and run,");
                                Thread.Sleep(1000);
                                Console.Write(" and run.");
                                Thread.Sleep(500);
                                if (fireplace == true)
                                {
                                    Console.WriteLine(" You walk through the door and the creature follows you through, the fireplace lights up the room around you, the popping of the dry sticks being the only sound");
                                    Console.WriteLine("It slows down for a second, almost scared. [run] or [fire]");
                                    room = 5;
                                }
                                else
                                {
                                    Console.WriteLine("The creature crawls through the door and looms over you, seemingly studying you.");
                                    Thread.Sleep(5000);
                                    Console.WriteLine("after about 5 seconds, The creature growls and decides to surrond the area in darkness. [press enter]");
                                    room = 0;
                                }
                                break;

                            default:
                                Console.WriteLine("Type something legible");
                                break;
                        }
                        break;
                    case 5:
                            switch (response)
                            {
                                case "run":
                                    Console.WriteLine("You try and dart past the shadow in its moment of hesitation, unfortunately, it wasn't scared of you and catches you [press enter]");
                                    room = 0;
                                    break;

                                case "fire":
                                    Console.WriteLine("You take a large stick beside the fire and light it. You wave it at the creature as it backs away...");
                                    Thread.Sleep(5000);
                                    Console.WriteLine("You back the creature into a corner and light it on fire. It smashes everything around it in a fit of pain...");
                                    Thread.Sleep(5000);
                                    Console.WriteLine("You make a run for it out of the door and slam it shut. You hear a pounding on the door and a human-like scream...");
                                    Thread.Sleep(5000);
                                    Console.WriteLine("After walking far out into the void you start to hear voices around you, both worried and confused, though unintelligible...");
                                    Thread.Sleep(5000);
                                    Console.WriteLine("The void around you seems to start crumbling around you, pieces of nothing falling into itself and soon everything fades...");
                                    Thread.Sleep(8000);
                                    Console.Clear();
                                    Console.WriteLine("“What happened?”");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("‘i dont know, he just suddenly combusted.’");
                                    Thread.Sleep(2500);
                                    Console.WriteLine("“That’s not supposed to happen.”");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("“Something must’ve gone wrong inside of there.”");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("‘in any case, this is valuable information on this experiment.’");
                                    Thread.Sleep(2600);
                                    Console.WriteLine("“WHAT ARE YOU DOING”");
                                    Thread.Sleep(1500);
                                    Console.WriteLine("‘what?’");
                                    Thread.Sleep(1500);
                                    Console.WriteLine("“HES WAKING UP”");
                                    Thread.Sleep(1500);
                                    Console.WriteLine("‘oh my go-’");
                                    Thread.Sleep(3000);
                                    Console.WriteLine("The end");
                                gameFinished = true;
                                    break;

                                default:
                                    Console.WriteLine("Type something legible");
                                    break;
                            }
                        break;
                        //Room Switch
                }//Help/Inv else
            } //Game Finished Loop
            
        }

    }
}