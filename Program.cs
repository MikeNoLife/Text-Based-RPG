using System;

namespace Text_Based_RPG
{
    class Program
    {
        static void TypeLine(string line) {
            Console.WriteLine(line);
            System.Threading.Thread.Sleep(300);
        }
        static void TypeLineFast(string line) {
            Console.WriteLine(line);
            System.Threading.Thread.Sleep(150);
        }
        static void Type(string line) {
            Console.Write(line);
        }
        static bool LevelUp(int lvl) {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (lvl < 9) {
                TypeLine("\nYou are now level: " + (lvl + 1) + ".");
            } else if (lvl == 9) {
                TypeLine("\nYou are now level: " + (lvl + 1) + ". (Max level)");
            }
            Console.ForegroundColor = ConsoleColor.White;
            return true;
        }
        static int [] StatsChange(int lvl, int hp, int ap, int dp, int gp, int xp, 
        int lvlAdd = 0, int hpAdd = 0, int apAdd = 0, int dpAdd = 0, int gpAdd = 0, int xpAdd = 0) {
            lvl += lvlAdd;
            hp += hpAdd;
            ap += apAdd;
            dp += dpAdd;
            gp += gpAdd;
            xp += xpAdd;
            if (hpAdd > 0 || apAdd > 0 || dpAdd > 0 || gpAdd > 0 || xpAdd > 0) {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("You gain: ");
            Console.ForegroundColor = ConsoleColor.White;
            }
            if (hpAdd > 0) {
                Console.Write(hpAdd + " Health. ");
            }
            if (apAdd > 0) {
                Console.Write(apAdd + " Attack. ");
            }
            if (dpAdd > 0) {
                Console.Write(dpAdd + " Defense. ");
            }
            if (gpAdd > 0) {
                Console.Write(gpAdd + " Gold. ");
            }
            if (xpAdd > 0) {
                Console.Write(xpAdd + " Experience Points. ");
            }
            if (hpAdd < 0 || apAdd < 0 || dpAdd < 0 || gpAdd < 0 || xpAdd < 0) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("You lose: ");
            Console.ForegroundColor = ConsoleColor.White;
            }
            if (hpAdd < 0) {
                Console.Write(Math.Abs(hpAdd) + " Health. ");
            }
            if (apAdd < 0) {
                Console.Write(Math.Abs(apAdd) + " Attack. ");
            }
            if (dpAdd < 0) {
                Console.Write(Math.Abs(dpAdd) + " Defense. ");
            }
            if (gpAdd < 0) {
                Console.Write(Math.Abs(gpAdd) + " Gold. ");
            }
            if (xpAdd < 0) {
                Console.Write(Math.Abs(xpAdd) + " Experience Points. ");
            }
            if (hpAdd != 0 || apAdd != 0 || dpAdd != 0 || gpAdd != 0 || xpAdd != 0) {
            TypeLine("");
            }     
            int [] statChanged = {lvl, hp, ap, dp, gp, xp};
            return statChanged; 
        }
        static void ExpNeeded(string line) {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            TypeLine(line);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static string Answer(string answer) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Your Answer: ");
            answer = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            return answer;
        }
        static void PressKey(string line) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(line);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void DealDamage(string line) {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(line);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Main(string[] args)
        {
            int lvl = 1;
            int hp = 100;
            int ap = 12;
            int dp = 4;
            int gp = 100;
            int xp = 0; 
            int [] statChanged = {0,0,0,0,0,0};
            int diceOne = 0;
            int diceTwo = 0;
            int diceTotal = 0;
            int rollCase = 0;
            int lastRollCase = 0;
            int caseRandom = 0;
            int dailyItemsBought = 0;
            int gpBefore = 0;
            int gpAfter = 0;
            int itemsBought = 0;
            int itemSmallHealthPotion = 0;
            int itemSmallWeaponEnchantment = 0;
            int itemSmallArmorEnchantment = 0;
            int itemBigHealthPotion = 0;
            int itemBigWeaponEnchantment = 0;
            int itemBigArmorEnchantment = 0;
            int itemExpPotion = 0;
            int itemBook = 0;
            int itemOrb = 0;
            int itemKey = 0;
            int itemHelmet = 0;
            int itemAmulet = 0;
            int itemBucket = 0;
            int itemMouse = 0;
            int sneakAttack = 0;
            int itemCookie = 0;
            int itemBoots = 0;
            int itemEye = 0;
            double mithrilMultiplier = 1;
            int questGiraffe = 0;
            int questGandalf = 0;
            int meetElfCount = 0;
            int hiddenPath = 0;
            int huntdown = 0;
            int enemyHealth = 0;
            int enemyAttack = 0;
            int gameDay = 1;
            int enemyLevel = 0;
            int enemyKilled = 0;
            int engageFight = 0;
            int engageElf = 0;
            int engageLeopard = 0;
            int engageDragon = 0;
            int engageGiant = 0;
            int cannotRunAway = 0;
            int runAway = 0;
            bool leveledUp = false;
            int warriorPassive = 0;
            int archerPassive = 0;
            int thiefPassiveMultiplier = 1;
            int oldElfCharge = 0;
            string answer = "";
            string playerClass = "";
            string enemyType = "";
            Random numberGen = new Random();
            Random enemyHealthRandom = new Random();
            Random enemyAttackRandom = new Random();
            diceOne = numberGen.Next(1, 7);
            diceTwo = numberGen.Next(1, 7);
            Console.ForegroundColor = ConsoleColor.White;
            TypeLine("Hello, and welcome to Text-Based RPG.");
            TypeLine("\nWhat kind of class are you? warrior/archer/thief");
            answer = Answer(answer);
            while (answer != "warrior" && answer != "archer" && answer != "thief") {
                TypeLine("Answer is invalid. Please type 'warrior', 'archer', or 'thief'");
                answer = Answer(answer);
            }
            TypeLine("You have chosen " + answer + " as your class.");
            if (answer == "warrior") {
                TypeLine("The warrior starts with an extra 2 Defense.");
                playerClass = "warrior";
                dp += 2;
            } else if (answer == "archer") { 
                TypeLine("The archer starts with an extra 6 Attack.");
                playerClass = "archer";
                ap += 6;
            } else if (answer == "thief") {
                TypeLine("The thief starts with an extra 300 Gold.");
                playerClass = "thief";
                gp += 300;
            }
            statChanged = StatsChange(lvl, hp, ap, dp, gp, xp);
            TypeLine("\nYour stats are:");
            TypeLine("Health: " + hp + ".");
            TypeLine("Attack: " + ap + ".");
            TypeLine("Defense: " + dp + ".");
            TypeLine("Gold: " + gp + ".");
            PressKey("Press a key to start the game.\n\n");
            Console.ReadKey(true);
            TypeLine("...");
            TypeLine("Wh..");
            TypeLine("Where am I?");
            TypeLine("You look around, and found yourself lost in a forest..");
            TypeLine("You decide to start exploring.");
            for (int gameTurns = 0; gameTurns != -1; gameTurns++)
            {        
                if (gameTurns != 0) {
                    hp = statChanged [1];
                    ap = statChanged [2];
                    dp = statChanged [3];
                    gp = statChanged [4];
                    xp = statChanged [5];
                    cannotRunAway = 0;
                    runAway = 0;
                    sneakAttack = 0;
                }
                if (ap <= 0) {
                    ap = 1;
                } 
                if (dp < 0) {
                    dp = 0;
                }
                if (gameTurns != 0 && lvl != 10 && enemyKilled == 0 && engageFight == 0) {
                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, xpAdd: 1);
                    xp = statChanged [5];
                }
                if (lvl == 1 && xp < 20 && engageFight == 0 && gameTurns != 0) {
                    ExpNeeded("You need: " + (20-xp) + " Experience Points to level up.");
                } else if (lvl == 2 && xp < 45 && engageFight == 0) {
                    ExpNeeded("You need: " + (45-xp) + " Experience Points to level up.");
                } else if (lvl == 3 && xp < 75 && engageFight == 0) {
                    ExpNeeded("You need: " + (75-xp) + " Experience Points to level up.");
                } else if (lvl == 4 && xp < 110 && engageFight == 0) {
                    ExpNeeded("You need: " + (110-xp) + " Experience Points to level up.");
                } else if (lvl == 5 && xp < 150 && engageFight == 0) {
                    ExpNeeded("You need: " + (150-xp) + " Experience Points to level up.");
                } else if (lvl == 6 && xp < 200 && engageFight == 0) {
                    ExpNeeded("You need: " + (200-xp) + " Experience Points to level up.");
                } else if (lvl == 7 && xp < 260 && engageFight == 0) {
                    ExpNeeded("You need: " + (260-xp) + " Experience Points to level up.");
                } else if (lvl == 8 && xp < 335 && engageFight == 0) {
                    ExpNeeded("You need: " + (335-xp) + " Experience Points to level up.");
                } else if (lvl == 9 && xp < 420 && engageFight == 0) {
                    ExpNeeded("You need: " + (420-xp) + " Experience Points to level up.");
                }
                if (xp >= 20  && lvl < 2) {
                    leveledUp = LevelUp(lvl);
                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, lvlAdd: 1, hpAdd: 25, apAdd: 4);       
                } else if (xp >= 45  && lvl < 3) {
                    leveledUp = LevelUp(lvl);
                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, lvlAdd: 1, hpAdd: 30, dpAdd: 2);
                } else if (xp >= 75  && lvl < 4) {
                    leveledUp = LevelUp(lvl);
                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, lvlAdd: 1, hpAdd: 35, apAdd: 3, dpAdd: 2);         
                } else if (xp >= 110  && lvl < 5) {
                    leveledUp = LevelUp(lvl);
                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, lvlAdd: 1, hpAdd: 40, apAdd: 4, dpAdd: 2);
                } else if (xp >= 150  && lvl < 6) {
                    leveledUp = LevelUp(lvl);
                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, lvlAdd: 1, hpAdd: 50, apAdd: 4, dpAdd: 3);
                } else if (xp >= 200  && lvl < 7) {
                    leveledUp = LevelUp(lvl);
                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, lvlAdd: 1, hpAdd: 60, apAdd: 6, dpAdd: 3); 
                } else if (xp >= 260  && lvl < 8) {
                    leveledUp = LevelUp(lvl);
                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, lvlAdd: 1, hpAdd: 70, apAdd: 6, dpAdd: 4); 
                } else if (xp >= 335  && lvl < 9) {
                    leveledUp = LevelUp(lvl);
                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, lvlAdd: 1, hpAdd: 80, apAdd: 8, dpAdd: 4);
                } else if (xp >= 420  && lvl < 10) {
                    leveledUp = LevelUp(lvl);
                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, lvlAdd: 1, hpAdd: 100, apAdd: 10, dpAdd: 5);
                }           
                if (leveledUp == true) {
                    lvl = statChanged [0];
                    hp = statChanged [1];
                    ap = statChanged [2];
                    dp = statChanged [3];
                    leveledUp = false;
                }
                enemyKilled = 0;
                if ((gameTurns %10 == 0 && gameTurns !=0 && engageFight == 0 && itemBoots == 0) ||
                    (gameTurns %11 == 0 && gameTurns !=0 && engageFight == 0 && itemBoots == 1)) {
                    dailyItemsBought = 0;
                    itemSmallHealthPotion = 0;
                    itemSmallWeaponEnchantment = 0;
                    itemSmallArmorEnchantment = 0;
                    itemBigHealthPotion = 0;
                    itemBigWeaponEnchantment = 0;
                    itemBigArmorEnchantment = 0;
                    itemExpPotion = 0;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    gameDay += 1;
                    TypeLine("\nThe darkness draws near, and you go to sleep. - Day: " + gameDay + ".");
                    if (itemCookie == 0) {
                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 20); 
                    } else if (itemCookie == 1) {
                        TypeLine("But first, you eat a cookie. Om nom!");
                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 50); 
                    }
                    hp = statChanged [1];    
                }
                           
                if (engageFight == 0) {
                    PressKey("Press a key to move forward.");
                    Console.Write("\t\t\t\t\tHealth: " + hp + ". Attack: " + ap + ". Defense: " + dp + ". Gold: " + gp + ".\n\n");
                    Console.ReadKey(true);
                    do {
                        if (itemEye == 0 && gameDay >= 5) {
                            if (engageElf == 0) {rollCase = numberGen.Next(1,12);}
                            if (engageElf == 2) {rollCase = numberGen.Next(2,12);}  
                        } else if (itemEye == 1 || gameDay <= 4) {
                            if (engageElf == 0) {rollCase = numberGen.Next(1,11);}
                            if (engageElf == 2) {rollCase = numberGen.Next(2,11);} 
                        }            
                    }
                    while (rollCase == lastRollCase); {
                    lastRollCase = rollCase;
                    }
                } else if (engageFight == 1) {
                    gameTurns -= 1;
                    engageFight = 0;
                    rollCase = 10;
                }
                switch (rollCase) { 
                    case 1: 
                        TypeLine("You stumble upon an Old Elf. He wants to ask you a question. What do you do? answer/ignore");
                        answer = Answer(answer);
                        caseRandom = numberGen.Next(1,4);
                        while (answer != "answer" && answer != "ignore") {
                            TypeLine("Answer is invalid. Please type 'answer' or 'ignore'");
                            answer = Answer(answer);
                        }
                        if (answer == "answer" && itemBook == 1) {
                            TypeLine("<<Wait.. is.. that my book that you got? Can I have it?>> yes/no");
                            answer = Answer(answer);
                            while (answer != "yes" && answer != "no") {
                                TypeLine("Answer is invalid. Please type 'yes' or 'no'");
                                answer = Answer(answer);
                            }
                            if (answer == "yes") {
                                itemBook = 2;
                                TypeLine("<<Thank you so much, this is a wonderful day. Here, have this.>>");
                                TypeLine("The Old Elf gave you some high quality shoulderpads.");
                                statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, dpAdd: 3);
                                TypeLine("The Old Elf bids you farewell.");
                            } else if (answer == "no") {
                                itemBook = 2;
                                TypeLine("<<You're lying!>>");
                                TypeLine("The Old Elf steals the book, but drops a potion while escaping.");
                                TypeLine("The Old Elf yells: <<Come see me again sometime and we can talk about life!>>");
                                statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 100);
                            }
                        } else if ((answer == "answer" && itemBook != 1) || (answer == "ignore" && caseRandom != 1)) {
                            if (answer == "ignore") {
                                TypeLine("The Old Elf insists, and you are forced to answer a question.");
                            }
                            if (gameDay <= 4) {
                                caseRandom = numberGen.Next(1,6); 
                            } else if (gameDay >= 5) {
                                caseRandom = numberGen.Next(1,7); 
                            }
                            if (gameDay >= 10 && engageElf == 0) {
                                caseRandom = 6;
                            }
                            if (meetElfCount < 3) {
                                meetElfCount += 1;
                                if (meetElfCount == 3) {
                                    caseRandom = 1;
                                }
                            }                                  
                            switch (caseRandom) {
                                case 1: 
                                    meetElfCount = 3;
                                    if (itemMouse == 1 && itemCookie == 1 && itemBoots == 1) {
                                        TypeLine("The Old Elf only has a sandwich to give you.");
                                        TypeLine("You eat it right away. It tastes old.");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 10);
                                        break;
                                    }
                                    TypeLine("<<What is the purpose of life?>> gaming/baking/hiking");
                                    answer = Answer(answer);
                                    while (answer != "gaming" && answer != "baking" && answer != "hiking") {
                                        TypeLine("Answer is invalid. Please type 'gaming', 'baking' or 'hiking'");
                                        answer = Answer(answer);
                                    }
                                    while ((answer == "gaming" && itemMouse == 1) || 
                                           (answer == "baking" && itemCookie == 1) ||
                                           (answer == "hiking" && itemBoots == 1)) {
                                            TypeLine("Choose another purpose this time. Please type 'gaming', 'baking' or 'hiking'");
                                            answer = Answer(answer);
                                    }
                                    if (answer == "gaming") {
                                        TypeLine("The Old Elf gives you a gameboy with a stealth-action game installed.");
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        TypeLine("You gain item 'Gameboy'");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        itemMouse = 1;
                                        TypeLine("The game taught you how to sneak attack. You will now do a sneak attack when engaging enemies.");
                                    } else if (answer == "baking") {
                                        TypeLine("The Old Elf gives you a jar of home-made cookies.");
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        TypeLine("You gain item 'Cookie Jar'");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        itemCookie = 1;
                                        TypeLine("They are perfect to eat as a midnight snack. You will eat a cookie before you go to sleep.");
                                    } else if (answer == "hiking") {
                                        TypeLine("The Old Elf gives you a new pair of boots.");
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        TypeLine("You gain item 'Boots of Hiking'");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        itemBoots = 1;
                                        TypeLine("With these boots, you are now able to walk 1 additional time before the sun sets.");
                                    }
                                    break;
                                case 2: 
                                    TypeLine("<<What color is the sky?>> blue/white/grey");
                                    answer = Answer(answer);
                                    while (answer != "blue" && answer != "white" && answer != "grey") {
                                        TypeLine("Answer is invalid. Please type 'blue', 'white' or 'grey'");
                                        answer = Answer(answer);
                                    }
                                    if (answer == "blue") {
                                        TypeLine("<<You're an optimist. You see hope where others see fear.>>");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 20);
                                    } else if (answer == "white") {
                                        TypeLine("<<You are open minded. You are open to ideas and opinions, and value everyone as equals.>>");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, xpAdd: 8);
                                        enemyKilled = 1;
                                    } else if (answer == "grey") {
                                        TypeLine("<<You're a realist. You see see darkness where other see delusions.>>");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, apAdd: 1);
                                    }
                                    break;
                                case 3: 
                                    TypeLine("<<Do you believe in a higher power than yourself?>> yes/no/maybe ");
                                    answer = Answer(answer);
                                    while (answer != "yes" && answer != "no" && answer != "maybe") {
                                        TypeLine("Answer is invalid. Please type 'yes', 'no' or 'maybe'");
                                        answer = Answer(answer);
                                    }
                                    if (answer == "yes") {
                                        TypeLine("<<Having faith in a higher power can benefit your recovery.>>");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 80, apAdd: -1);
                                    } else if (answer == "no") {
                                        TypeLine("<<Having faith in yourself makes your strong.>>");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, apAdd: 6, dpAdd: -1);
                                    } else if (answer == "maybe") {
                                        TypeLine("<<Having doubts in yourself opens your mind and can be a motivator.>>");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 20, apAdd: -1, dpAdd: 1);
                                    }
                                    break;
                                case 4: 
                                    TypeLine("<<What time of year do you prefer?>> spring/summer/autumn/winter");
                                    answer = Answer(answer);
                                    while (answer != "spring" && answer != "summer" && answer != "autumn" && answer != "winter") {
                                        TypeLine("Answer is invalid. Please type 'spring', 'summer', 'autumn' or 'winter'");
                                        answer = Answer(answer);
                                    }
                                    if (answer == "spring") {
                                        TypeLine("<<Ahh.. spring.. The time of year when it gets warmer and the trees start to bloom.>>");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 30);
                                    } else if (answer == "summer") {
                                        TypeLine("<<Everyone loves the summer. The warm feeling of a summer breeze is so amazing.>>");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 10, apAdd: 1);
                                    } else if (answer == "autumn") {
                                        TypeLine("<<The most beautiful time of year is definitely autumn.>>");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, xpAdd: 10);
                                        enemyKilled = 1;
                                    } else if (answer == "winter") {
                                        TypeLine("<<Even if you love the snow, or spending the holidays with your family, winter is such an amazing time of year.>>");
                                        TypeLine("The Old Elf gives you a wrapped gift.");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 10, gpAdd: 100);
                                    }
                                    break;
                                case 5: 
                                    TypeLine("<<What is underneath the rock?>> stick/nut/penny/leaf");
                                    answer = Answer(answer);
                                    while (answer != "stick" && answer != "nut" && answer != "penny" && answer != "leaf") {
                                        TypeLine("Answer is invalid. Please type 'stick', 'nut', 'penny' or 'leaf'");
                                        answer = Answer(answer);
                                    }
                                    if (answer == "stick") {
                                        TypeLine("<<A small wooden stick that probably fell down from a giant tree.>>");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, apAdd: 3);
                                    } else if (answer == "nut") {
                                        TypeLine("<<\"Hard as a nut\" is how the phrase goes, I'm sure you are pretty dense too..>>");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, dpAdd: 1);
                                    } else if (answer == "penny") {
                                        TypeLine("<<If I had one of these for every dumb face I asked a question, I'd be rich.>>");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 150);
                                    } else if (answer == "leaf") {
                                        TypeLine("<<Ahh.. The Leaf.. I once knew a ninja.. with red eyes.. that came from the hidden village of the..>>");
                                        TypeLine("<<Uhm.. what was I saying again?..>>");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, xpAdd: 12);
                                        enemyKilled = 1;
                                    }
                                    break;
                                case 6: 
                                    TypeLine("<<Do you want to fight me?>> yes/no");
                                    answer = Answer(answer);
                                    while (answer != "yes" && answer != "no") {
                                        TypeLine("Answer is invalid. Please type 'yes' or 'no'");
                                        answer = Answer(answer);
                                    }
                                    if (answer == "yes") {
                                        engageElf = 1;
                                        engageFight = 1;
                                    } else if (answer == "no") {
                                        TypeLine("<<Oh.. okay then.>>");
                                    }
                                    break;
                            }
                        } else if (answer == "ignore") {
                            TypeLine("You ignore the Old Elf.");
                            TypeLine("You never really liked old people anyway.");
                            statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 10, xpAdd: 5);
                            enemyKilled = 1;
                        }
                        break;          
                    case 2: 
                        TypeLine("The road ahead looks dangerous. What do you do? move/return");
                        answer = Answer(answer);
                        while (answer != "move" && answer != "return") {
                            TypeLine("Answer is invalid. Please type 'move' or 'return'");
                            answer = Answer(answer);
                        }
                        if (answer == "move" && questGandalf != 2) {
                            caseRandom = numberGen.Next(1,5);                  
                            switch (caseRandom) {
                                case 1: 
                                    TypeLine("You fall into a deadly trap.");
                                    if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10);}
                                    if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -5);}
                                    break;
                                case 2: 
                                    TypeLine("You move swiftly through the area.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 15);
                                    break;
                                case 3: 
                                    TypeLine("You walk into a bear trap, but luckily it's just a dud.");
                                    if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, dpAdd: 1, apAdd: -1);}
                                    if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, dpAdd: 1);}
                                    break;
                                case 4: 
                                    TypeLine("While going through the area, you find a chest. Do you open it? yes/no");
                                    answer = Answer(answer);
                                    while (answer != "yes" && answer != "no") {
                                    TypeLine("Answer is invalid. Please type 'yes' or 'no'");
                                    answer = Answer(answer);
                                    }
                                    if (answer == "yes") {
                                        caseRandom = numberGen.Next(1,4);
                                        switch (caseRandom) {
                                            case 1: 
                                                TypeLine("You find a large amount of gold.");
                                                statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 200);
                                                break;
                                            case 2: 
                                                TypeLine("The chest bites you.");
                                                if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -20);}
                                                if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10);} 
                                                break;
                                            case 3: 
                                                TypeLine("You find a weapon enchantment.");
                                                statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, apAdd: 2);
                                                break;
                                        }
                                    } else if (answer == "no") {
                                        caseRandom = numberGen.Next(1,4);
                                        switch (caseRandom) {
                                            case 1: 
                                                TypeLine("You left the chest, and managed to get safely into the next area.");
                                                statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 20);
                                                break;
                                            case 2: 
                                                TypeLine("As you walk away, the chest starts crying.");
                                                TypeLine("Out of instinct, you attend to the chest, and waste 2 hours making it stop crying.");
                                                if (itemAmulet == 0 || (itemAmulet == 1 && hp <= 10)) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, dpAdd: -1);}
                                                if (itemAmulet == 1 && hp > 10) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10);} 
                                                break;
                                            case 3: 
                                                TypeLine("The chest suddenly spits out some gold. You grab it and run away in fear.");
                                                if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10, gpAdd: 100);}
                                                if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 100);} 
                                                break;
                                        }
                                    } 
                                    break; 
                            }
                        } else if (answer == "return" && questGandalf != 2) {
                            caseRandom = numberGen.Next(1,5);                    
                            switch (caseRandom) {
                                case 1: 
                                    TypeLine("You are ambushed by a Dark Wizard. You run away in fear.. Obviously");
                                    if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10);}
                                    if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -5);} 
                                    break;
                                case 2: 
                                    TypeLine("A wild goose quacks, and clearly tells you that you're trespassing the goose's territory.");
                                    if ((gp >= 40 && itemAmulet == 0) || (gp >= 10 && itemAmulet == 1)) {  
                                        TypeLine("You offer some gold, excuse yourself and moves on.");
                                        if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: -40);}
                                        if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: -10);} 
                                    } else {
                                        TypeLine("You offer some gold, but it's not enough. The goose assault you.");
                                        if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -20, gpAdd: -gp);}
                                        if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10, gpAdd: -gp);} 
                                    }   
                                    break;
                                case 3: 
                                    TypeLine("You returned safely.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 10);
                                    break;
                                case 4: 
                                    TypeLine("While returning to where you came from, you notice something on the ground. Do you pick it up? yes/no");
                                    answer = Answer(answer);
                                    while (answer != "yes" && answer != "no") {
                                    TypeLine("Answer is invalid. Please type 'yes' or 'no'");
                                    answer = Answer(answer);
                                    } 
                                    if (answer == "yes" && itemBook == 0) {
                                        itemBook = 1;
                                        TypeLine("You pick it up, it's an old book.");
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        TypeLine("You gain item: 'Old Book'");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        TypeLine("You wonder who it belongs to..");
                                              
                                    } else if (answer == "yes" && itemBook != 0) {
                                        caseRandom = numberGen.Next(1,4);
                                        switch (caseRandom) {
                                            case 1:
                                                TypeLine("It's a bowl of the most yummy brownies ever! You enjoy them.");
                                                statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 40);
                                                break;
                                            case 2:
                                                TypeLine("It's a manual. 'Weak spots of common forest enemies'.");
                                                statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, apAdd: 2);
                                                break;
                                            case 3:
                                                TypeLine("It's a ring. You try to wear it, but Gollum appears, takes it from you, punch you in the stomach and runs away.");
                                                if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -20, dpAdd: 1);}
                                                if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10, dpAdd: 1);} 
                                                break;
                                        }
                                    } else if (answer == "no") {
                                        caseRandom = numberGen.Next(1,4);
                                        switch (caseRandom) {
                                            case 1:
                                                TypeLine("It did not interest you, you're a strong independent " + playerClass + ".");
                                                statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, dpAdd: 2);
                                                break;
                                            case 2:
                                                TypeLine("As you walk away, you carelessly trip over a rock and into a wild boar. The boar bites your face.");
                                                if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -20);}
                                                if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10);} 
                                                break;
                                            case 3:
                                                TypeLine("You walk away and wonder if you made the right choice.");
                                                statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 20);
                                                break;
                                        }
                                    }
                                    break;
                            }
                        } else if (questGandalf == 2){
                            TypeLine("You find traces that are shaped like hobbit feet.");
                            TypeLine("You sense the hobbit is nearby.");
                            questGandalf = 3;
                            statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, xpAdd: 5);
                            enemyKilled = 1;
                        }
                        break;                   
                    case 3: 
                        TypeLine("You find a big red button. What do you do? push/ignore");
                        answer = Answer(answer);
                        while (answer != "push" && answer != "ignore") {
                            TypeLine("Answer is invalid. Please type 'push' or 'ignore'");
                            answer = Answer(answer);
                        }
                        if (answer == "push") {
                            caseRandom = numberGen.Next(1,5);                         
                            switch (caseRandom) {
                                case 1: 
                                    TypeLine("You push it");
                                    TypeLine("A pack of wild jaguars suddenly attacks you");
                                    if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -20);}
                                    if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10);} 
                                    break;
                                case 2: 
                                    TypeLine("You push it.");
                                    TypeLine("A waitress emerge and serves you a grand meal.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 20, dpAdd: 1);
                                    break;
                                case 3: 
                                    TypeLine("You push it.");
                                    TypeLine("Somewhere in the world, a volcano erupts and kills an entire village.");
                                    if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10);}
                                    if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -5);} 
                                    break;
                                case 4: 
                                    if (itemBucket == 0) {
                                        TypeLine("You push it.");
                                        TypeLine("A rusty bucket falls on your head");
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        TypeLine("You gain item: 'Rusty Bucket'");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        itemBucket = 1;
                                        if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10);}
                                        if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -5);} 
                                    } else if (itemBucket != 0) {
                                        TypeLine("You push it.");
                                        TypeLine("Nothing happens.");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 10);
                                    }
                                    break;           
                            }
                        } else if (answer == "ignore") {
                            caseRandom = numberGen.Next(1,5);                         
                            switch (caseRandom) {
                                case 1: 
                                    TypeLine("You push it anyway.");
                                    TypeLine("Gold falls from the sky.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 150);
                                    break;
                                case 2: 
                                    if (questGiraffe == 0) {
                                        TypeLine("A giraffe appears and push it instead.");
                                        TypeLine("A hole in the ground opens up and the giraffe falls down.");
                                        TypeLine("You've made up your mind, you're gonna save this poor animal.");
                                        TypeLine("Quest Started: \"Save The Giraffe.\"");
                                        questGiraffe = 1;
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, apAdd: 2);
                                    } else if (questGiraffe != 0) {
                                        TypeLine("Another giraffe appears and push it instead.");
                                        TypeLine("No hole opened up this time.. phew.");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, apAdd: 1);
                                    }
                                    break;
                                case 3: 
                                    TypeLine("You ignore it and walk away.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 10);
                                    break;
                                case 4: 
                                    TypeLine("You ignore it, but can't shake the feeling that you made a huge mistake.");
                                    TypeLine("Blinded by regret, you run back to push the button, only to find it gone.");
                                    TypeLine("You feel sadness.");
                                    TypeLine("You feel lost.");
                                    TypeLine("You feel despair.");
                                    TypeLine("You feel.. empty.");
                                    if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, apAdd: -1, dpAdd: -1);}
                                    if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, apAdd: -1);} 
                                    break;
                            }
                        }
                        break;
                    case 4: 
                        TypeLine("A group of thugs wants to play a card game. (100 Gold required) play/run");
                        answer = Answer(answer);
                        while (answer != "play" && answer != "run") {
                            TypeLine("Answer is invalid. Please type 'play' or 'run'");
                            answer = Answer(answer);
                        }
                        if (answer == "play" && gp >= 100) {
                            if (questGandalf == 0) {
                                if (lvl <= 3) {
                                    caseRandom = numberGen.Next(1,9);
                                } else if (lvl >= 4 && lvl <= 6) {
                                    caseRandom = numberGen.Next(3,9);
                                } else if (lvl >= 7) {
                                    caseRandom = numberGen.Next(5,9);
                                }        
                            } else if (questGandalf != 0) {
                                if (lvl <= 3) {
                                    caseRandom = numberGen.Next(1,7);
                                } else if (lvl >= 4 && lvl <= 6) {
                                    caseRandom = numberGen.Next(3,7);
                                } else if (lvl >= 7) {
                                    caseRandom = numberGen.Next(5,7);
                                }
                            }                   
                            switch (caseRandom) {
                                case 1: 
                                    TypeLine("You lost the game, and you lose a huge amount of gold.");
                                    if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: -100);}
                                    if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: -60);} 
                                    break;
                                case 2: 
                                    TypeLine("You won the game, and are rewarded some gold.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 75);
                                    break;
                                case 3: 
                                    TypeLine("You lost the game, and you lose a good amount of gold.");
                                    if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: -75);}
                                    if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: -40);} 
                                    break;
                                case 4: 
                                    TypeLine("You won the game, and are rewarded lots of gold.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 125);
                                    break;
                                case 5: 
                                    TypeLine("You lost the game, and you lose a small amount of gold.");
                                    if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: -50);}
                                    if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: -20);} 
                                    break;                              
                                case 6: 
                                    TypeLine("You won the game, and are rewarded an enormous amount of gold.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 200);
                                    break;
                                case 7: case 8: 
                                    TypeLine("Just as the dealer is about to give you the cards, Gandalf appears from the bushes.");
                                    TypeLine("<<Can you help me find the hobbit?>> Gandalf asks. yes/no");
                                    answer = Answer(answer);
                                        while (answer != "yes" && answer != "no") {
                                            TypeLine("Answer is invalid. Please type 'yes' or 'no'");
                                            answer = Answer(answer);
                                        }
                                    if (answer == "yes") {
                                        TypeLine("<<Thank you! Now, make haste!>> Gandalf yells as he runs into the bushes again.");
                                        TypeLine("Quest Started: \"Find the Hobbit.\"");
                                        questGandalf = 1;
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, xpAdd: 5);
                                        enemyKilled = 1;
                                    } else if (answer == "no") {
                                        TypeLine("You reject the wizard of this silly quest, and proceed to win the grand prize of the card game.");
                                        questGandalf = 4;
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 500);
                                    }
                                    break;
                            }
                        } else if (answer == "play" && gp < 100) {
                            TypeLine("You don't have enough gold.");
                            TypeLine("The thugs get angry and beat you to a pulp.");
                            if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -20);}
                            if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10);} 
                        } else if (answer == "run") {
                            caseRandom = numberGen.Next(1,4);  
                            switch (caseRandom) {
                                case 1:
                                    TypeLine("You ran away, but at what cost? You peed your pants.");
                                    TypeLine("You managed to find some new pants in the bushes, but they were all sweaty and uncomfortable.");
                                    if (itemAmulet == 0 || (itemAmulet == 1 && hp <= 10)) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, apAdd: -1);}
                                    if (itemAmulet == 1 && hp > 10) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10);}
                                    break;
                                case 2:
                                    TypeLine("You try to run away, but they hunt you down.");                             
                                    if (huntdown == 0) {
                                        TypeLine("As a last resort, you offer them a long-term payment plan.");
                                        TypeLine("You sold your grandparents to work at their mining grounds outside of the forest.");
                                        huntdown = 1;
                                        TypeLine("They thank you, and award you riches of gold,");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 300);
                                    } else if (huntdown != 0) {
                                        TypeLine("You don't have anything to offer them anymore, and they cut you up with their axes.");
                                        if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -40);}
                                        if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -20);}
                                    }                                  
                                    break;
                                case 3: 
                                    TypeLine("You ran away safely.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, xpAdd: 4);
                                    enemyKilled = 1;
                                    break;
                            }   
                        }
                        break;                   
                    case 5:
                        TypeLine("You find a water source. What do you do? drink/move");
                        answer = Answer(answer);
                        while (answer != "drink" && answer != "move") {
                            TypeLine("Answer is invalid. Please type 'drink' or 'move'");
                            answer = Answer(answer);
                        }              
                        if (answer == "drink" && questGandalf != 1) {
                            caseRandom = numberGen.Next(1,5);                   
                            switch (caseRandom) {
                                case 1: 
                                    TypeLine("The water was poisonous.");
                                    if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10);}
                                    if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -5);}
                                    break;
                                case 2: 
                                    TypeLine("The water was refreshing.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 20);
                                    break;
                                case 3: 
                                    TypeLine("You found gold while drinking.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 60);
                                    break;
                                case 4: 
                                    TypeLine("You heard a voice that screams: <<Don't drink the water!>>.");
                                    TypeLine("Someone probably just saved your life.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, dpAdd: 1);
                                    break;
                            }
                        } else if (answer == "move" && questGandalf != 1) {
                            caseRandom = numberGen.Next(1,5);                         
                            switch (caseRandom) {
                                case 1: 
                                    TypeLine("You found a bottle of vitamin-water. You drink it.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, dpAdd: 1);
                                    break;
                                case 2: 
                                    TypeLine("A wild alligator suddenly bites your leg.");
                                    if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10);}
                                    if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -5);} 
                                    break;
                                case 3: 
                                    TypeLine("You move safely to the next area.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 30);
                                    break;
                                case 4: 
                                    if ((gp >= 30 && itemAmulet == 0) || (gp >= 10 && itemAmulet == 1)) {
                                        TypeLine("A wild monkey steals some gold from you.");
                                        if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: -30);}
                                        if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: -10);} 
                                    } else {
                                        TypeLine("A wild monkey steals all your gold.");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: -gp);
                                    }
                                    break;                   
                            }
                        } else if (questGandalf == 1) {
                            TypeLine("Next to the water, you found some lembas breadcrumbs.");
                            TypeLine("There has probably been a hobbit here.");  
                            questGandalf = 2;     
                            statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, xpAdd: 5);
                            enemyKilled = 1;
                        }
                        break;  
                    case 6: 
                        TypeLine("While walking through the area, you think about your past. What do you think about? family/lover/journey");
                        answer = Answer(answer);
                        while (answer != "family" && answer != "lover" && answer != "journey") {
                            TypeLine("Answer is invalid. Please type 'family', 'lover' or 'journey'");
                            answer = Answer(answer);
                        }
                        if (answer == "family" && itemKey != 1) {
                            caseRandom = numberGen.Next(1,5);                         
                            switch (caseRandom) {
                                case 1: 
                                    TypeLine("You remember your dad.");
                                    TypeLine("He used to beat you once a week.");
                                    TypeLine("You feel the pain linger through your body.");
                                    if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -20);}
                                    if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10);} 
                                    break;
                                case 2: 
                                    TypeLine("You remember your mom.");
                                    TypeLine("She used to make the best waffles ever.");
                                    TypeLine("You feel a warmth inside you.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 10, dpAdd: 1);
                                    break;
                                case 3: 
                                    TypeLine("You remember your sister.");
                                    TypeLine("When you were kids you used to play with wooden swords. You never won even once.");
                                    TypeLine("You feel a stronger fighting spirit.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, apAdd: 3);
                                    break;
                                case 4: 
                                    TypeLine("You remember your crazy uncle.");
                                    TypeLine("He used to take you to a casino. You were allowed to play once, and you won tons of gold.");
                                    TypeLine("While thinking, you found some gold laying on the ground.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 60);
                                    break;
                            }
                        } else if (answer == "lover" && itemKey != 1) {
                            caseRandom = numberGen.Next(1,5);                         
                            switch (caseRandom) {
                                case 1: 
                                    TypeLine("You remember your first love.");
                                    TypeLine("You met in a bar, and it ended in a bar.");
                                    TypeLine("You wonder if that's a common first love story.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 30);
                                    break;
                                case 2: 
                                    TypeLine("You remember your worst love.");
                                    TypeLine("All was well for 5 years, but the relationship ended in bankruptcy.");
                                    if ((gp >= 50 && itemAmulet == 0) || (gp >= 20 && itemAmulet == 1)) {
                                        TypeLine("You think about all the Gold you lost, and suddenly you seem to have lost some more.");
                                        if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: -50);}
                                        if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: -20);} 
                                    } else if ((gp > 0 && gp < 50 && itemAmulet == 0) || (gp > 0 && gp < 20 && itemAmulet == 1)) {       
                                        TypeLine("You think about all the Gold you lost, and realize all your gold is now gone.");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: -gp);
                                    } else if (gp == 0) {
                                        TypeLine("To this day, you're still broke.");
                                    }
                                    break;
                                case 3: 
                                    TypeLine("You remember your best love.");
                                    TypeLine("It only lasted a year, but it was the best year in your life.");
                                    TypeLine("Somehow, you feel like you can get back together, and your passion skyrockets.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 10, apAdd: 2);
                                    break;
                                case 4: 
                                    TypeLine("You remember your one-night stands.");
                                    TypeLine("It's been a while since you were chasing love on the streets in California.");
                                    TypeLine("You were young and dumb, but you gained a lot of experience.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, xpAdd: 8);
                                    enemyKilled = 1;
                                    break;
                            }
                        } else if (answer == "journey" && itemKey != 1) {
                            caseRandom = numberGen.Next(1,5);                         
                            switch (caseRandom) {
                                case 1: 
                                    TypeLine("You remember your journey across the ocean.");
                                    TypeLine("The feeling of being seasick for months instantly comes to mind.");
                                    TypeLine("It's such a strong memory, and you throw up.");
                                    if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10);}
                                    if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -5);} 
                                    break;
                                case 2: 
                                    TypeLine("You remember your journey to the capital city.");
                                    TypeLine("Big buildings, many roads and a ton of people.");
                                    TypeLine("You spent all your Gold on a toy shield. You remember it protecting you from your sister once.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 20, dpAdd: 1);
                                    break;
                                case 3: 
                                    TypeLine("You remember your journey to the moon.");
                                    TypeLine("Well, it was not the moon, that was just the lie your dad told you.");
                                    TypeLine("In fact, it wasn't a journey at all. You were just taken out to the jard and got beat up. You feel weak.");
                                    if (itemAmulet == 0 || (itemAmulet == 1 && hp <= 5)) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, apAdd: -1);}
                                    if (itemAmulet == 1 && hp > 5) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -5);} 
                                    break;
                                case 4: 
                                    TypeLine("You remember your journey to.. where were you headed?");
                                    TypeLine("All you can remember is that you woke up, in this forest actually.");
                                    TypeLine("Where were you going? How did you end up here?");
                                    TypeLine("All you know is that you must beat the king, and that you must hurry.");
                                    TypeLine("You are pumped up, and ready to continue this journey that you started..");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, apAdd: 4);
                                    break;
                            }
                        } else if (itemKey == 1) {
                            TypeLine("Before you get lost into your own thoughts, you notice an old abondoned shed.");
                            TypeLine("You try to open it, but it's locked.");
                            TypeLine("Try the 'Rusty Key'? yes/yes");
                            answer = Answer(answer);
                            while (answer != "yes") {
                                TypeLine("Answer is invalid. You MUST open the door. Type 'yes'.. NOW!");
                                answer = Answer(answer);
                            }
                            TypeLine("You open the door..");
                            itemKey = 2;
                            TypeLine("There is..");
                            TypeLine("Absolutely..");
                            TypeLine("Nothing..");
                            TypeLine("Inside..");
                            TypeLine("But somehow..");
                            TypeLine("You feel like you found absolutely everything inside.");
                            TypeLine("You feel enlightened.");
                            statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 100, xpAdd: 50);
                            enemyKilled = 1;
                        }
                        break;
                    case 7: 
                        if (itemBucket != 1) {
                            if (gameDay == 1) {
                                TypeLine("You see a merchant, and greet each other.");
                                TypeLine("Some other day, you might feel like shopping here.");
                                statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, xpAdd: 2);
                                enemyKilled = 1;
                                break;
                            }
                            TypeLine("You find a merchant. What do you do? shop/move");
                            answer = Answer(answer);
                            while (answer != "shop" && answer != "move") {
                                TypeLine("Answer is invalid. Please type 'shop' or 'move'");
                                answer = Answer(answer);
                            }
                        } else if (itemBucket == 1) {
                            itemBucket = 2;
                            TypeLine("There's a merchant here that seems to be looking for something.");
                            TypeLine("The merchant asks you if you have seen a bucket somewhere. Do you give it back? yes/no");
                            answer = Answer(answer);
                            while (answer != "yes" && answer != "no") {
                                TypeLine("Answer is invalid. Please type 'move' or 'shop'");
                                answer = Answer(answer);
                            }
                            if (answer == "yes") {
                                TypeLine("You give the bucket back. The merchant thanks you and gives you a special potion.");
                                TypeLine("You drink the potion, and instantly feel like you could lift a horse.");
                                statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 30, apAdd: 5);
                            } else if (answer == "no") {
                                TypeLine("The merchants grabs the bucket away from you and hits your head with it.");
                                TypeLine("Your head hurts, but what doesn't kill you makes you stronger.");
                                statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -30, dpAdd: 2);
                            }
                        }
                        if (answer == "move") {
                            caseRandom = numberGen.Next(1,3);                         
                            switch (caseRandom) {
                                case 1: 
                                    TypeLine("You pat yourself on the back for not spending anything this time.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 10);
                                    break;
                                case 2: 
                                    TypeLine("The merchant hopes you will buy something next time.");
                                    TypeLine("<<Good luck on your travels " + playerClass + ". Take this>>");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 50);
                                    break;
                            }
                        } else if (answer == "shop" && (dailyItemsBought != 7 || itemsBought != 4)) {  
                            gpBefore = gp;        
                            while (answer != "leave" && (dailyItemsBought != 7 || itemsBought != 4)) {
                                Console.Write("Here are todays items: ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                TypeLineFast("Gold: " + gp + ".");
                                Console.ForegroundColor = ConsoleColor.White;
                                if (itemSmallHealthPotion == 0) {
                                    TypeLineFast("1: Small Health Potion (20 Health) - 100 Gold");
                                }
                                if (itemSmallWeaponEnchantment == 0) {
                                    TypeLineFast("2: Small Weapon Enchantment (3 Attack) - 150 Gold");
                                }
                                if (itemSmallArmorEnchantment == 0) {
                                    TypeLineFast("3: Small Armor Enchantment (1 Defense) - 150 Gold");
                                }
                                if (itemBigHealthPotion == 0) {
                                    TypeLineFast("4: Big Health Potion (40 Health) - 250 Gold");
                                }
                                if (itemBigWeaponEnchantment == 0) {
                                    TypeLineFast("5: Big Weapon Enchantment (6 Attack) - 400 Gold");
                                }
                                if (itemBigArmorEnchantment == 0) {
                                    TypeLineFast("6: Big Armor Enchantment (2 Defense) - 400 Gold");
                                }
                                if (itemExpPotion == 0) {
                                    TypeLineFast("7: Experience Potion (20 Experience Points) - 200 Gold");
                                }
                                if (itemOrb == 0) {
                                    TypeLineFast("8: Shiny Orb - 600 Gold");
                                }
                                if (itemOrb != 0 && itemHelmet == 0) {
                                    TypeLineFast("8: Helmet (Enemy cannot crit) - 600 Gold");
                                } 
                                if (itemKey == 0) {
                                    TypeLineFast("9: Rusty Key - 750 Gold");
                                }
                                if (itemKey != 0 && itemAmulet == 0) {
                                    TypeLineFast("9: Amulet (Bad luck has less impact) - 750 Gold");
                                }
                                    TypeLineFast("Type the item number if you want to buy, or leave the shop. #/leave.");
                                    answer = Answer(answer);
                                if  ((answer == "1" && gp >= 100 && itemSmallHealthPotion == 0) ||
                                     (answer == "2" && gp >= 150 && itemSmallWeaponEnchantment == 0) ||
                                     (answer == "3" && gp >= 150 && itemSmallArmorEnchantment == 0) ||
                                     (answer == "4" && gp >= 250 && itemBigHealthPotion == 0) ||
                                     (answer == "5" && gp >= 400 && itemBigWeaponEnchantment == 0) ||
                                     (answer == "6" && gp >= 400 && itemBigArmorEnchantment == 0) ||
                                     (answer == "7" && gp >= 200 && itemExpPotion == 0) ||
                                    ((answer == "8" && gp >= 600) && (itemOrb == 0 || itemHelmet == 0)) ||
                                    ((answer == "9" && gp >= 750) && (itemKey == 0 || itemAmulet == 0))) {
                                    
                                    if (answer == "1") {
                                        itemSmallHealthPotion = 1; 
                                        dailyItemsBought += 1;
                                        TypeLine("You bought 'Small Health Potion'.");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 20, gpAdd: -100);
                                    }
                                    if (answer == "2") {
                                        itemSmallWeaponEnchantment = 1;
                                        dailyItemsBought += 1;
                                        TypeLine("You bought 'Small Weapon Enchantment'.");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, apAdd: 3, gpAdd: -150);
                                    }
                                    if (answer == "3") {
                                        itemSmallArmorEnchantment = 1;
                                        dailyItemsBought += 1;
                                        TypeLine("You bought 'Small Armor Enchantment'.");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, dpAdd: 1, gpAdd: -150);
                                    }
                                    if (answer == "4") {
                                        itemBigHealthPotion = 1;
                                        dailyItemsBought += 1;
                                        TypeLine("You bought 'Big Health Potion'.");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 40, gpAdd: -250);
                                    }
                                    if (answer == "5") {
                                        itemBigWeaponEnchantment = 1;
                                        dailyItemsBought += 1;
                                        TypeLine("You bought 'Big Weapon Enchantment'.");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, apAdd: 6, gpAdd: -400);
                                        }
                                    if (answer == "6") {
                                        itemBigArmorEnchantment = 1;
                                        dailyItemsBought += 1;
                                        TypeLine("You bought 'Big Armor Enchantment'."); 
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, dpAdd: 2, gpAdd: -400);
                                        }
                                    if (answer == "7") {
                                        itemExpPotion = 1;
                                        dailyItemsBought += 1;
                                        TypeLine("You bought 'Experience Potion'.");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, xpAdd: 20, gpAdd: -200);
                                    }
                                    if (answer == "8") {
                                        if (itemOrb == 0) {
                                            itemOrb = 1; 
                                            itemsBought += 1;
                                            TypeLine("You bought 'Shiny Orb'.");
                                            statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: -600);
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            TypeLine("You gain item: 'Shiny Orb'.");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            TypeLine("Merchant: <<Ahh.. I found that orb in a cave, I think it's cursed.>>");                                        
                                            TypeLine("The merchant smiles suspiciously.");
                                        } else if (itemHelmet == 0) {
                                            itemHelmet = 1;
                                            itemsBought += 1;
                                            TypeLine("You bought 'Helmet'.");
                                            statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: -600);
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            TypeLine("You gain item: 'Helmet'.");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            TypeLine("Merchant: <<This helmet has a magic property that makes enemies unable to critical strike.>>");                                        
                                        }                            
                                    }
                                    if (answer == "9") {
                                        if (itemKey == 0) {
                                            itemKey = 1;
                                            itemsBought += 1;
                                            TypeLine("You bought 'Rusty Key'.");
                                            statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: -750);
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            TypeLine("You gain item: 'Rusty Key'.");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            TypeLine("Merchant: <<Somewhere, there's a door, which this key unlocks.>>"); 
                                        } else if (itemAmulet == 0) {
                                            itemAmulet = 1;
                                            itemsBought += 1;
                                            TypeLine("You bought 'Amulet'.");
                                            statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: -750);
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            TypeLine("You gain item: 'Amulet'.");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            TypeLine("Merchant: <<This amulet is said to reduce the effect of negative outcomes.>>");                                        
                                        }         
                                    }
                                    TypeLine("");
                                } else if ((answer == "1" && gp < 100 && itemSmallHealthPotion == 0) ||
                                           (answer == "2" && gp < 150 && itemSmallWeaponEnchantment == 0) ||
                                           (answer == "3" && gp < 150 && itemSmallArmorEnchantment == 0) ||
                                           (answer == "4" && gp < 250 && itemBigHealthPotion == 0) ||
                                           (answer == "5" && gp < 400 && itemBigWeaponEnchantment == 0) ||
                                           (answer == "6" && gp < 400 && itemBigArmorEnchantment == 0) ||
                                           (answer == "7" && gp < 200 && itemExpPotion == 0) ||
                                           (answer == "8" && gp < 600 && (itemOrb == 0 || itemHelmet == 0)) ||
                                           (answer == "9" && gp < 750 && (itemKey == 0 || itemAmulet == 0))) {
                                    TypeLine("You do not have enough gold to buy this item.\n");
                                } else if (answer == "leave") {
                                    gpAfter = gp;
                                    if (gpBefore > gpAfter) {
                                        TypeLine("The merchant waves goodbye.");
                                    } else if (gpBefore == gpAfter) {
                                        TypeLine("The merchant is offended that you are just browsing without buying.");
                                        TypeLine("The merchant pulls out a stick and hits your head.");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10);
                                    }
                                } else { 
                                    TypeLine("Answer is invalid. Please type item number '#' or 'leave'\n");
                                }
                                hp = statChanged [1];
                                ap = statChanged [2];
                                dp = statChanged [3];
                                gp = statChanged [4];
                                xp = statChanged [5];
                            }
                            if (dailyItemsBought == 7 && itemsBought == 4) {
                                TypeLine("There's no items left in the shop today. The merchant waves goodbye.");
                            }
                        } else if (answer == "shop" && dailyItemsBought == 7 && itemsBought == 4) {
                            TypeLine("You already bought all of the items today. Check back tomorrow for a restock.");
                            TypeLine("The merchant is angered and throws a rotten onion at you.");
                            statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -5);
                        }
                        break;  
                    case 8: 
                        TypeLine("You discover a hidden cave. explore/move");
                        answer = Answer(answer);
                        while (answer != "explore" && answer != "move") {
                            TypeLine("Answer is invalid. Please type 'explore' or 'move'");
                            answer = Answer(answer);
                        }
                        if (answer == "explore") {
                            TypeLine("You enter the cave.");
                            if (questGiraffe != 1) {
                                if (lvl <=3) {
                                    caseRandom = numberGen.Next(1,8);    
                                } else if (lvl >= 4) {
                                    caseRandom = numberGen.Next(2,8);    
                                if (lvl >= 6 && hiddenPath == 0) {
                                    caseRandom = 7;
                                    hiddenPath = 1;
                                }
                            }                       
                                switch (caseRandom) {
                                    case 1: 
                                        TypeLine("It's a trap!");
                                        if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10);}
                                        if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -5);}
                                        break;
                                    case 2: 
                                        TypeLine("You found a chest with some gold.");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 100);
                                        break;
                                    case 3: 
                                        TypeLine("You found an apple");
                                        TypeLine("It's delicious, and oddly enough it's not rotten.");
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 20);
                                        break;
                                    case 4: 
                                        TypeLine("You found an odd shaped mushroom.");
                                        TypeLine("You eat it. It tasted awful.");
                                        if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10, dpAdd: 1);}
                                        if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, dpAdd: 1);}
                                        break;
                                    case 5: 
                                        engageFight = 1;
                                        break;
                                    case 6: 
                                        TypeLine("You discover a huge treasure of gold and claim it.");
                                        TypeLine("On your way out of the cave, you come across a goblin.");
                                        TypeLine("The goblin asks you to return the gold. What do you do? return/keep");
                                        answer = Answer(answer);
                                            while (answer != "return" && answer != "keep") {
                                                TypeLine("Answer is invalid. Please type 'return' or 'keep'");
                                                answer = Answer(answer);
                                            }
                                        if (answer == "return") {
                                            TypeLine("You return the gold.");
                                            TypeLine("The goblin is relieved, and awards you an armor enchantment.");
                                            statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, dpAdd: 1);
                                        } else if (answer == "keep") {                     
                                            TypeLine("You keep the gold.");
                                            TypeLine("The goblin accepts your greed, and let you carry on.");
                                            statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 200);
                                        }                     
                                        break;
                                    case 7: 
                                        if (playerClass == "warrior" && lvl >= 5 && warriorPassive == 0) {
                                            TypeLine("You found a hidden path.");
                                            TypeLine("You discover the ancient ruins of the Old Warriors.");
                                            TypeLine("Deep within the deepest chamber, you find the \"Health Regen Cape\".");
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            TypeLine("You gain item: 'Health Regen Cape'.");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            TypeLine("With this cape, you will regenerate 30 Health after every battle.");
                                            warriorPassive = 1;
                                        } else if (playerClass == "archer" && lvl >= 5 && archerPassive == 0) {
                                            TypeLine("You found a hidden path.");
                                            TypeLine("You discover the ancient ruins of the Fabled Archers.");
                                            TypeLine("Deep within the deepest chamber, you find the \"Critical Enchantment Quiver\".");
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            TypeLine("You gain item: 'Critical Enchantment Quiver'.");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            TypeLine("With this quiver, your attacks will always deal critical damage.");
                                            archerPassive = 1;
                                        } else if (playerClass == "thief" && lvl >= 5 && thiefPassiveMultiplier == 1) {
                                            TypeLine("You found a hidden path.");
                                            TypeLine("You discover the ancient ruins of the Wealthy Thieves.");
                                            TypeLine("Deep within the deepest chamber, you find the \"Golden Amulet\".");
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            TypeLine("You gain item: 'Golden Amulet'.");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            TypeLine("With this amulet, you will gain twice the gold from slain enemies.");
                                            thiefPassiveMultiplier = 2;
                                        } else if (lvl < 5) {
                                            TypeLine("You found a hidden path, but you're not strong enough to follow it.");
                                            TypeLine("A voice whispering said <<Come back.. when you're uhm.. like level 5 or stronger..>>");
                                        } else {
                                            TypeLine("You found a hidden pa.. wait, isn't this familiar?");
                                            TypeLine("Yeah.. you've already been here.. There's nothing left.");
                                            TypeLine("Before you went back, you spent some time meditating.");
                                            statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 30);
                                        }              
                                        break;
                                }
                            } else if (questGiraffe == 1) {
                                questGiraffe = 2;
                                TypeLine("You found the giraffe. It's tied up.");
                                TypeLine("You untie the giraffe and guide it outside.");
                                TypeLine("<<Thank you for your bravery noble " + playerClass + ".>>");
                                TypeLine("<<Here's your reward.>>");
                                if (playerClass == "warrior") {
                                    TypeLine("You gain the mightiest sword the world has ever seen.");
                                } else if (playerClass == "archer") {
                                    TypeLine("You gain the swiftest bow the world has ever seen.");
                                } else if (playerClass == "thief") {
                                    TypeLine("You gain the sharpest dagger the world has ever seen");
                                }
                                TypeLine("Quest Completed: \"Save the Giraffe.\"");
                                statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, apAdd: 12);
                            }
                        } else if (answer == "move") {
                            caseRandom = numberGen.Next(1,5);                         
                            switch (caseRandom) {
                                case 1: 
                                    TypeLine("As you walk away, you hear distant screams from the cave.");
                                    TypeLine("You get scared and walk away even faster.");
                                    TypeLine("The fear took a good amount of energy away from you.");
                                    if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10);}
                                    if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -5);}
                                    break;
                                case 2: 
                                    TypeLine("You read somewhere that throwing Gold into a cave gives you energy.");
                                    TypeLine("Believing everything you read on the internet, you threw gold into the cave.");
                                    TypeLine("You feel relaxed.");
                                    if ((itemAmulet == 0 && gp >= 200) || (itemAmulet == 1 && gp >= 120)) {
                                        if (itemAmulet == 0 && gp >= 200) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 50, gpAdd: -150);}
                                        if (itemAmulet == 1 && gp >= 120) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 50, gpAdd: -100);}
                                    } else if ((gp > 0 && gp < 200 && itemAmulet == 0) || (gp > 0 && gp < 120 && itemAmulet == 1)) { 
                                        statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 30, gpAdd: -gp);
                                    } else if (gp == 0) {
                                        TypeLine("Oh wait.. you don't have any gold.. You just threw away a photo of your mom..");
                                        TypeLine("You silently walk away like nothing ever happened.");
                                    }
                                    break;
                                case 3: 
                                    TypeLine("Your inner voice says <<You're such a wimp, no wonder your father beat you.>>");
                                    TypeLine("Anxiety strikes, and you lose confidence in yourself.");
                                    if (itemAmulet == 0) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -10, apAdd: -1);}
                                    if (itemAmulet == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, apAdd: -1);}
                                    break;
                                case 4: 
                                    TypeLine("A cave is for losers anyway, at least that's what you're telling yourself.");
                                    TypeLine("You're happy about your decision, you have a forest to explore and enemies to face.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 20, apAdd: 4);
                                    break;
                            }
                        }
                        break;     
                    case 11: 
                        if (engageLeopard != 2 || engageDragon != 2 || engageGiant != 2) {
                            TypeLine("You suddenly find yourself surrounded by crows.. What is going on?");
                            TypeLine("There are 3 perfectly squared stones on the ground.");
                            TypeLine("And a note is hanging from a rope close by the stones, it reads:");
                            TypeLine("Step on one of these stones to choose which one to fight.");
                            if (engageLeopard == 0) {TypeLine("Left: Giant Leopard - 200 Health, 40 Attack (2-6 = You attack. 7-12 = Enemy attack.)");}
                            if (engageDragon == 0) {TypeLine("Middle: Fiery Dragon - 500 Health, 120 Attack (2-10 = You attack. 11-12 = Enemy attack.)");}
                            if (engageGiant == 0) {TypeLine("Right: Armored Giant - 2000 Health, 30 Attack (2-8 = You attack. 9-12 = Enemy attack.)");}
                            TypeLine("If you are able to defeat all 3 creatures, come here again and claim your reward.)");
                            TypeLine("What do you do? left/middle/right/escape");
                        } else if (engageLeopard == 2 || engageDragon == 2 || engageGiant == 2) {
                            TypeLine("You find that place with the crows again..");
                            TypeLine("But now there are no crows.. only feathers and a note on the ground.. The note reads:");
                            TypeLine("Congratulations, you defeated all my creatures.");
                            TypeLine("Take this eye, It's called \"The Mangekyou Sharingan\".");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            TypeLine("You gain item 'Eye of Itachi'");
                            Console.ForegroundColor = ConsoleColor.White;
                            itemEye = 1;
                            TypeLine("You implant the eye, crows will now aid you in combat.");
                            TypeLine("The crows attack randomly and deal 40% of your damage.");
                            break;
                        }
                        answer = Answer(answer);
                        while ((answer == "left" && engageLeopard == 2) || 
                               (answer == "middle" && engageDragon == 2) ||
                               (answer == "right" && engageGiant == 2)) {
                            TypeLine("That creature is already dead. Please type 'left', 'right', 'middle' or 'escape'");
                            answer = Answer(answer);
                        }

                        while (answer != "left" && answer != "middle" && answer != "right" && answer != "escape") {
                            TypeLine("Answer is invalid. Please type 'left', 'right', 'middle' or 'escape'");
                            answer = Answer(answer);
                        }
                        if (answer == "left" || answer == "middle" || answer == "right") {
                            if (answer == "left") {
                                engageLeopard = 1;
                                cannotRunAway = 1;
                            }
                            if (answer == "middle") {
                                engageDragon = 1;
                                cannotRunAway = 1;
                            }
                            if (answer == "right") {
                                engageGiant = 1;
                                cannotRunAway = 1;
                            }
                            engageFight = 1;
                        } else if (answer == "escape") {
                            TypeLine("As you walk away, the crows disappear.");
                            TypeLine("Was this all an illusion?..");
                            TypeLine("You regret backing out of a fight, and you feel ashamed of yourself.");
                            statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, apAdd: -1);
                        }
                        break;          
                    case 9: case 10:
                        TypeLine("You come across an enemy.");       
                        if (gameDay == 1 || gameDay == 2) {
                            caseRandom = numberGen.Next(1,2);  
                        } else if (gameDay == 3) {
                            caseRandom = numberGen.Next(1,3);
                        } else if (gameDay == 4) {
                            caseRandom = numberGen.Next(2,4);
                        } else if (gameDay == 5) {
                            caseRandom = numberGen.Next(2,5);
                        } else if (gameDay == 6) {
                            caseRandom = numberGen.Next(3,5);
                        } else if (gameDay == 7) {
                            caseRandom = numberGen.Next(3,6);
                        } else if (gameDay == 8) {
                            caseRandom = numberGen.Next(4,6);
                        } else if (gameDay == 9) {
                            caseRandom = numberGen.Next(4,7);
                        } else if (gameDay == 10 || gameDay == 11) {
                            caseRandom = numberGen.Next(5,7);
                        } else if (gameDay >= 12) {
                            caseRandom = 6;
                        }
                        if (engageElf == 1) {
                            enemyType = "Old Elf";
                            enemyHealth = 666;
                            enemyAttack = 0;
                        } else if (engageLeopard == 1) {
                            enemyType = "Giant Leopard";
                            enemyHealth = 200;
                            enemyAttack = 40;
                        } else if (engageDragon == 1) {
                            enemyType = "Fiery Dragon";
                            enemyHealth = 500;
                            enemyAttack = 120;
                        } else if (engageGiant == 1) {
                            enemyType = "Armored Giant";
                            enemyHealth = 2000;
                            enemyAttack = 30;
                        } else if (engageElf != 1 || engageLeopard != 1 || engageDragon != 1 || engageGiant != 1) {
                            if (caseRandom == 1) {
                                enemyType = "Bandit";
                                enemyLevel = numberGen.Next(1,4);
                                if (enemyLevel == 1) {enemyHealth = enemyHealthRandom.Next(40,61); enemyAttack = enemyAttackRandom.Next(8,15);}
                                if (enemyLevel == 2) {enemyHealth = enemyHealthRandom.Next(50,76); enemyAttack = enemyAttackRandom.Next(12,19);}
                                if (enemyLevel == 3) {enemyHealth = enemyHealthRandom.Next(60,91); enemyAttack = enemyAttackRandom.Next(16,23);}
                            } else if (caseRandom == 2) {
                                enemyType = "Orc";
                                enemyLevel = numberGen.Next(2,5);
                                if (enemyLevel == 2) {enemyHealth = enemyHealthRandom.Next(60,81); enemyAttack = enemyAttackRandom.Next(14,23);}
                                if (enemyLevel == 3) {enemyHealth = enemyHealthRandom.Next(80,101); enemyAttack = enemyAttackRandom.Next(20,29);}
                                if (enemyLevel == 4) {enemyHealth = enemyHealthRandom.Next(100,121); enemyAttack = enemyAttackRandom.Next(26,35);}
                            } else if (caseRandom == 3) {
                                enemyType = "Wolf Rider";
                                enemyLevel = numberGen.Next(3,6);
                                if (enemyLevel == 3) {enemyHealth = enemyHealthRandom.Next(70,91); enemyAttack = enemyAttackRandom.Next(20,31);}
                                if (enemyLevel == 4) {enemyHealth = enemyHealthRandom.Next(90,121); enemyAttack = enemyAttackRandom.Next(28,39);}
                                if (enemyLevel == 5) {enemyHealth = enemyHealthRandom.Next(110,151); enemyAttack = enemyAttackRandom.Next(36,47);}
                            } else if (caseRandom == 4) {
                                enemyType = "Ogre";
                                enemyLevel = numberGen.Next(5,8);
                                if (enemyLevel == 5) {enemyHealth = enemyHealthRandom.Next(300,401); enemyAttack = enemyAttackRandom.Next(50,61);}
                                if (enemyLevel == 6) {enemyHealth = enemyHealthRandom.Next(350,501); enemyAttack = enemyAttackRandom.Next(55,66);}
                                if (enemyLevel == 7) {enemyHealth = enemyHealthRandom.Next(400,601); enemyAttack = enemyAttackRandom.Next(60,71);}
                            } else if (caseRandom == 5) {
                                enemyType = "Giant";
                                enemyLevel = numberGen.Next(8,10);
                                if (enemyLevel == 7) {enemyHealth = enemyHealthRandom.Next(600,801); enemyAttack = enemyAttackRandom.Next(70,81);}
                                if (enemyLevel == 8) {enemyHealth = enemyHealthRandom.Next(800,1001); enemyAttack = enemyAttackRandom.Next(80,91);}
                                if (enemyLevel == 9) {enemyHealth = enemyHealthRandom.Next(1000,1201); enemyAttack = enemyAttackRandom.Next(90,101);}
                            } else if (caseRandom == 6) {
                                enemyLevel = 10;
                                enemyType = "King of the Forest";
                                enemyHealth = 4000;
                                enemyAttack = 100;
                            }
                        }
                        if (questGandalf == 3 && enemyType != "King of the Forest" 
                                              && enemyType != "Old Elf"
                                              && enemyType != "Giant Leopard"
                                              && enemyType != "Fiery Dragon"
                                              && enemyType != "Armored Giant" 
                                              && enemyLevel < lvl) {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            TypeLine("The enemy is holding the hobbit as a hostage!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }      
                        Type("Enemy type: " + enemyType);
                        if (enemyType == "Bandit" || enemyType == "Orc" || enemyType == "Wolf Rider" || enemyType == "Ogre" || enemyType == "Giant" || enemyType == "King of the Forest") {
                            TypeLine(" (Level: " + enemyLevel + ").");
                            if (enemyLevel > lvl) {
                            Console.ForegroundColor = ConsoleColor.Red;
                            TypeLine("Warning: Enemy level is high.");
                            Console.ForegroundColor = ConsoleColor.White;
                            }
                        } else {
                            TypeLine(".");
                        }
                        TypeLine("The " + enemyType + " have: " + enemyHealth + " Health and " + enemyAttack + " Attack.");
                        TypeLine("What do you do? fight/run");
                        answer = Answer(answer);
                        while (answer != "fight" && answer != "run") {
                            TypeLine("Answer is invalid. Please type 'fight' or 'run'");
                            answer = Answer(answer);
                        }
                        if ((answer == "run" && gameDay >= 12 && engageElf != 1) || 
                            (answer == "run" && cannotRunAway == 1)) {
                            TypeLine("You can't run away.");
                        } else if (answer == "run") {
                            if (engageElf == 1) {
                                engageElf = 0;
                            }
                            runAway = 1;
                            TypeLine("You ran away.");
                            if (questGandalf == 3 && enemyType != "King of the Forest" && enemyType != "Old Elf" && enemyLevel < lvl) {
                                TypeLine("As you run away, you hear the hobbit scream in pain. The hobbit will most likely die now.");
                                questGandalf = 4;
                            }
                            statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -5);
                        }     
                        int fightTurns = 0;
                        if (sneakAttack == 0 && itemMouse == 1 && runAway != 1) {
                            TypeLine("You sneak up to enemy and ambush it.");
                            DealDamage("You deal: ");
                            TypeLine(Math.Ceiling(ap*1.5) + " damage.");
                            enemyHealth -= Convert.ToInt32(Math.Ceiling(ap*1.5));
                            sneakAttack = 1;
                            if (enemyHealth > 0) {
                                TypeLine(enemyType + " Health: " + enemyHealth + ".");
                            }
                        }                
                        while (enemyHealth > 0 && hp > 0 && runAway != 1) { 
                            fightTurns++;
                            diceOne = numberGen.Next(1, 7);
                            diceTwo = numberGen.Next(1, 7);  
                            diceTotal = diceOne + diceTwo;      
                            if (fightTurns == 1 && ((enemyType == "Wolf Rider") || (enemyType == "Giant Leopard"))) {                     
                                PressKey("Press a key to roll the dices. (2-6 = You attack. 7-12 = Enemy attack.)\n\n");
                            } else if (fightTurns == 1 && ((enemyType == "Fiery Dragon") || (enemyType == "Old Elf"))) {
                                PressKey("Press a key to roll the dices. (2-10 = You attack. 11-12 = Enemy attack.)\n\n");
                            } else if (fightTurns > 1) {
                                PressKey("Press a key to continue.\n\n");
                            } else {
                                PressKey("Press a key to roll the dices. (2-8 = You attack. 9-12 = Enemy attack.)\n\n");
                            }
                            Console.ReadKey(true);
                            Console.Write("You rolled: " + diceOne + " and " + diceTwo + ". Total: ");
                            if ((diceTotal <= 10 && (enemyType == "Fiery Dragon" || enemyType == "Old Elf")) || 
                                (diceTotal <= 8 && enemyType != "Wolf Rider" && enemyType != "Giant Leopard") ||
                                 diceTotal <= 6) {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            } else {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            TypeLine(diceTotal + ".");
                            Console.ForegroundColor = ConsoleColor.White;
                            if (enemyType == "Old Elf") {
                                if (oldElfCharge == 0) {
                                    oldElfCharge = 1;
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    TypeLine("The old elf mumbles something while gathering energy inside his palms.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                } else if (oldElfCharge == 1) {
                                    oldElfCharge = 2;
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    TypeLine("The energy is getting larger and brighter.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                } else if (oldElfCharge == 2) {
                                    oldElfCharge = 3;
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    TypeLine("Okay shit.. now it looks deadly as well, embrace for impact!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                } else if (oldElfCharge == 3) {
                                    oldElfCharge = 4;
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    TypeLine("The old elf unleashes a vast amount of energy towards you.");
                                    TypeLine("You can see his hair turning spiky and yellow.");
                                    TypeLine("Before you know it, you are hit with a major blast.");
                                    TypeLine("All you can hear is the sound of shockwaves, and the old elf yelling..");
                                    TypeLine("KAAAMEEEHAAAAMEEEEHAAA!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: Convert.ToInt32(hp*0.5*-1));
                                    hp = statChanged [1];
                                    enemyHealth = 1;
                                    TypeLine("The old elf looks tired, and his hp is reduced to 1.");

                                }             
                            } if ((diceTotal <= 10 && (enemyType == "Fiery Dragon" || enemyType == "Old Elf")) || 
                                (diceTotal <= 8 && enemyType != "Wolf Rider" && enemyType != "Giant Leopard") ||
                                 diceTotal <= 6) {
                                if (diceTotal == 2 || archerPassive == 1) {
                                    TypeLine("You deal a critical hit. (50% more damage)");
                                    DealDamage("You deal: ");
                                    TypeLine(Math.Ceiling(ap*1.5) + " damage.");
                                        enemyHealth -= Convert.ToInt32(Math.Ceiling(ap*1.5));
                                } else if (diceTotal != 2) {                          
                                    DealDamage("You deal: ");        
                                    TypeLine(ap + " damage.");
                                    enemyHealth -= ap;                     
                                }
                            } else {
                                if (diceTotal == 12 && dp < enemyAttack*1.5*mithrilMultiplier && itemHelmet == 0) {
                                    TypeLine("The " + enemyType + " deals a critical hit. (50% more damage)");  
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -Convert.ToInt32(Math.Ceiling(enemyAttack*1.5*mithrilMultiplier)-dp)); 
                                    hp = statChanged [1];
                                    if (hp > 0) {TypeLine("Health: " + hp + ".");}     
                                } else if ((diceTotal == 12 && dp < enemyAttack*mithrilMultiplier && itemHelmet == 1) ||
                                           (diceTotal != 12 && dp < enemyAttack*mithrilMultiplier)) {
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: -Convert.ToInt32(Math.Ceiling(enemyAttack*mithrilMultiplier)-dp));
                                    hp = statChanged [1];
                                    if (hp > 0) {TypeLine("Health: " + hp + ".");}     
                                } else {
                                    TypeLine("You fully block the attack and counterattack");
                                    if (archerPassive == 1) {
                                        TypeLine("You deal a critical hit. (50% more damage)");
                                    }
                                    DealDamage("You deal: ");
                                    if (archerPassive == 0) {
                                        Type(ap + " damage.");
                                        enemyHealth -= ap;
                                    } else if (archerPassive == 1) {
                                        Type(Math.Ceiling(ap*1.5) + " damage.\n");
                                        enemyHealth -= Convert.ToInt32(Math.Ceiling(ap*1.5));
                                    }                       
                                } 
                            }
                            if (enemyHealth > 0) {
                                    TypeLine(enemyType + " Health: " + enemyHealth + ".");
                            }
                            if (enemyHealth > 0 && hp > 0) {
                                caseRandom = numberGen.Next(1,9);
                                switch (caseRandom) {
                                    case 1:
                                        if (enemyType != "King of the Forest" && enemyType != "Bandit" && enemyType != "Old Elf") {
                                            TypeLine("The " + enemyType + " grows stronger and gain 1 Attack.");
                                            enemyAttack += 1;
                                            TypeLine(enemyType + " Attack: " + enemyAttack + ".");
                                        } else if (enemyType == "King of the Forest") {
                                            TypeLine("The King of the Forest sharpens his royal blade and gain 4 Attack.");
                                            enemyAttack += 4;
                                            TypeLine(enemyType + " Attack: " + enemyAttack + ".");
                                        }
                                        break;
                                    case 2: 
                                        if (enemyType == "Orc" || enemyType == "Wolf Rider") {
                                            TypeLine("The " + enemyType + " drinks a potion and gain 10 Health.");
                                            enemyHealth += 10;
                                            TypeLine(enemyType + " Health: " + enemyHealth + ".");
                                        } else if (enemyType != "Bandit" && enemyType != "Orc" && enemyType != "Wolf Rider" && enemyType != "King of the Forest" && enemyType != "Old Elf") {
                                            TypeLine("The " + enemyType + " drinks a potion and gain 20 Health.");
                                            enemyHealth += 20;
                                            TypeLine(enemyType + " Health: " + enemyHealth + ".");
                                        } else if (enemyType == "King of the Forest") {
                                            TypeLine("The King of the Forest drinks from his royal bottle and gain 100 Health.");
                                            enemyHealth += 100;
                                            TypeLine(enemyType + " Health: " + enemyHealth + ".");
                                        }
                                        break;
                                    case 3: case 4: case 5: 
                                    if (itemEye == 1) {
                                        TypeLine("A crow appears and attacks the enemy.");
                                        DealDamage("The crow deals: ");
                                        TypeLine(Math.Ceiling(ap*0.4) + " damage.");
                                        enemyHealth -= Convert.ToInt32(Math.Ceiling(ap*0.5));
                                        if (enemyHealth > 0) {
                                            TypeLine(enemyType + " Health: " + enemyHealth + ".");
                                        }
                                    }
                                        break;
                                    case 6:
                                    if (itemEye == 1) {
                                        TypeLine("A flock of crows appears and attacks the enemy.");
                                        DealDamage("The crows deals: ");
                                        TypeLine(Math.Ceiling(ap*1.2) + " damage.");
                                        enemyHealth -= Convert.ToInt32(Math.Ceiling(ap*0.5));
                                        if (enemyHealth > 0) {
                                            TypeLine(enemyType + " Health: " + enemyHealth + ".");
                                        }
                                    }
                                        break; 
                                    case 7: case 8:
                                        break;
                                    } 
                                }                       
                            }
                            if (enemyHealth <= 0) {
                                TypeLine("The " + enemyType + " died.");
                                enemyKilled = 1;
                                if (enemyType == "Bandit") {
                                    if (enemyLevel == 1) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 50*thiefPassiveMultiplier, xpAdd: 2);}
                                    if (enemyLevel == 2) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 75*thiefPassiveMultiplier, xpAdd: 3);}
                                    if (enemyLevel == 3) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 100*thiefPassiveMultiplier, xpAdd: 4);}
                                } else if (enemyType == "Orc") {
                                    if (enemyLevel == 2) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 125*thiefPassiveMultiplier, xpAdd: 4);}
                                    if (enemyLevel == 3) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 150*thiefPassiveMultiplier, xpAdd: 5);}
                                    if (enemyLevel == 4) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 175*thiefPassiveMultiplier, xpAdd: 6);}
                                } else if (enemyType == "Wolf Rider") {
                                    if (enemyLevel == 3) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 200*thiefPassiveMultiplier, xpAdd: 7);}
                                    if (enemyLevel == 4) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 225*thiefPassiveMultiplier, xpAdd: 8);}
                                    if (enemyLevel == 5) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 250*thiefPassiveMultiplier, xpAdd: 10);} 
                                } else if (enemyType == "Ogre") {
                                    if (enemyLevel == 5) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 275*thiefPassiveMultiplier, xpAdd: 9);}
                                    if (enemyLevel == 6) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 300*thiefPassiveMultiplier, xpAdd: 11);}
                                    if (enemyLevel == 7) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 350*thiefPassiveMultiplier, xpAdd: 13);} 
                                } else if (enemyType == "Giant") {
                                    if (enemyLevel == 7) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 350*thiefPassiveMultiplier, xpAdd: 12);}
                                    if (enemyLevel == 8) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 400*thiefPassiveMultiplier, xpAdd: 15);}
                                    if (enemyLevel == 9) {statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 500*thiefPassiveMultiplier, xpAdd: 18);} 
                                } else if (enemyType == "King of the Forest") {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    TypeLine("\nYou defeated the last boss and won the game! GG");
                                    Console.ReadKey();
                                    Console.ReadKey();
                                    Environment.Exit(0);
                                } else if (enemyType == "Old Elf") {
                                    engageElf = 2;
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, apAdd: 5, dpAdd: 2, gpAdd: 750*thiefPassiveMultiplier, xpAdd: 25);                                 
                                } else if (enemyType == "Giant Leopard") {
                                    engageLeopard = 2;
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 500*thiefPassiveMultiplier, xpAdd: 20);                               
                                    } else if (enemyType == "Fiery Dragon") {
                                    engageDragon = 2;
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 500*thiefPassiveMultiplier, xpAdd: 20);                                 
                                } else if (enemyType == "Armored Giant") {
                                    engageGiant = 2;
                                statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, gpAdd: 500*thiefPassiveMultiplier, xpAdd: 20);                                   
                                }  
                                if (questGandalf == 3 && enemyLevel < lvl) {
                                    TypeLine("You successfully saved the hobbit.");
                                    TypeLine("Quest Completed: \"Find the Hobbit.\"");
                                    questGandalf = 4;
                                    TypeLine("Gandalf appears from the bushes again..");
                                    TypeLine("He rips off the armor from the hobbit and gives it to you as a reward.");
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    TypeLine("You gain item 'Mithril Armor'.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    mithrilMultiplier = 0.7;
                                    TypeLine("The armor gives you 30% damage reduction from enemy attacks. (Before defense is applied).");
                                }
                                if (warriorPassive == 1) {
                                    TypeLine("You regenerate 30 Health.");
                                    statChanged = StatsChange(lvl, hp, ap, dp, gp, xp, hpAdd: 30);
                                    hp = statChanged [1]; 
                                    TypeLine("Health: " + hp + ".");
                                }
                            }
                        break;              
                }
                hp = statChanged [1];
                if (hp <= 0 && itemOrb == 1) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    TypeLine("\nYou died.");
                    System.Threading.Thread.Sleep(1500);
                    Console.ForegroundColor = ConsoleColor.White;
                    TypeLine("Wait.. what is this?.");
                    System.Threading.Thread.Sleep(400);
                    TypeLine("Your 'Shiny Orb' is glowing.");
                    System.Threading.Thread.Sleep(400);
                    TypeLine("The orb is shattered.");
                    System.Threading.Thread.Sleep(400);
                    TypeLine("You feel alive again.");
                    System.Threading.Thread.Sleep(400);
                    statChanged = StatsChange(lvl, hp=0, ap, dp, gp, xp, hpAdd: 200);
                    if (questGandalf == 3) {
                        TypeLine("Also btw.. the hobbit died.");
                        questGandalf = 4;
                    }
                    itemOrb = 2;
                    enemyKilled = 1;
                    if (engageElf == 1) {engageElf = 0;}
                    if (engageLeopard == 1) {engageLeopard = 0;}
                    if (engageDragon == 1) {engageDragon = 0;}
                    if (engageGiant == 1) {engageGiant = 0;}
                } else if (hp <= 0 && itemOrb != 1) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    TypeLine("\nYou died, better luck next time.");
                    Console.ReadKey();
                    Console.ReadKey();
                    Environment.Exit(0);
                }                 
            }           
            //alternative winning condition?
            //Console.ForegroundColor = ConsoleColor.Green;
            //TypeLine("\nYou made it through the forest and into safety. GG");
            //Console.ReadKey();
            //Console.ReadKey();
        }
    }
}