namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int numberOfRaccoonsInWoods = 3;
            int numberOfRaccoonsGoingHome = 2;
            int numberOfRaccoonsRemaining = numberOfRaccoonsInWoods - numberOfRaccoonsGoingHome;

            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int flowers = 5;
            int bees = 3;
            int fewerBeesThanFlowers = flowers - bees;
            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int pigeonEatingBreadcrumbs = 1;
            int pigeonArriving = 1;
            pigeonEatingBreadcrumbs += pigeonArriving;
            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int owlsOnFence = 3;
            int owlsArriving = 2;
            owlsOnFence += owlsArriving;
            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int beaversWorking = 2;
            int beaversSwimming = 1;
            beaversWorking -= beaversSwimming;
            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int toucansOnLimb = 2;
            int toucansArriving = 1;
            toucansOnLimb += toucansArriving;
            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int squirrelsInTree = 4;
            int numberOfNuts = 2;
            int numberOfSquirrelsMoreThanNuts = squirrelsInTree - numberOfNuts;
            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            int numberOfQuarters = 1;
            int numberOfDimes = 1;
            int numberOfNickels = 2;
            decimal moneyForMrsHilt = (decimal)(numberOfQuarters * .25) + (decimal)(numberOfDimes * .10) + (decimal)(numberOfNickels * .05);
            System.Console.WriteLine(moneyForMrsHilt);
            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int numberOfMuffinsBrier = 18;
            int numberOfMuffinsMacAdams = 20;
            int numberOfMuffinsFlannery = 17;
            int numberOfMuffinsFirstGrade = numberOfMuffinsBrier + numberOfMuffinsMacAdams + numberOfMuffinsFlannery;
            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            decimal yoyoPrice = .24M;
            decimal whistlePrice = .14M;
            decimal totalSpentByHilt = yoyoPrice + whistlePrice;
            /*
            13. Mrs. Hilt made 5 Rice Krispies Treats. She used 8 large marshmallows
            and 10 mini marshmallows. How many marshmallows did she use
            altogether?
            */
            int numberOfMarshmallowsLarge = 8;
            int numberOfMarshmallowsSmall = 10;
            int numberOfMarshmallowsTotal = (numberOfMarshmallowsSmall + numberOfMarshmallowsLarge);

            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int snowForHilt = 29;
            int snowForBrecknock = 17;
            int snowDifference = snowForHilt - snowForBrecknock;


            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            decimal moneyOfMrsHilt = 10m;
            decimal priceOfToyTruck = 3m;
            decimal priceOfPencilCase = 2m;
            moneyOfMrsHilt -= (priceOfToyTruck + priceOfPencilCase);

            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int numberOfMarblesOfJosh = 16;
            int numberOfMarblesLost = 7;
            numberOfMarblesOfJosh -= numberOfMarblesLost;
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int numberOfSeashellsOfMegan = 19;
            int numberOfSeashellsGoal = 25;
            int numberOfSeashellsNeeded = numberOfSeashellsGoal - numberOfSeashellsOfMegan;
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int numberOfBalloonsOfBrad = 17;
            int numberOfBallonsRed = 8;
            int numberOfBallonsGreen = numberOfBalloonsOfBrad - numberOfBallonsRed;

            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int numberOfBooksOnShelf = 38;
            int numberOfBooksReturned = 10;
            numberOfBooksOnShelf += numberOfBooksReturned;
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            const int beeLegs = 6;
            int numberOfBees = 8;
            int totalBeeLegs = beeLegs * numberOfBees;
            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            decimal iceCreamConePrice = .99M;
            decimal numberOfIceCreamCones = 2M;
            decimal totalCostofIceCreamCones = iceCreamConePrice * numberOfIceCreamCones;

            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int numberOfRocksForBorder = 125;
            int numberOfRocksOfMrsHilt = 64;
            int numberOfRocksNeeded = numberOfRocksForBorder - numberOfRocksOfMrsHilt;
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int numberOfMarblesOfMrsHilt = 38;
            int numberOfMarblesLostHilt = 15;
            numberOfMarblesOfMrsHilt -= numberOfMarblesLostHilt;
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int concertDistance = 78;
            int distanceTravelled = 32;
            concertDistance -= distanceTravelled;
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time (in minutes) did she spend shoveling snow?
            */
            int snowShovelingSaturdayMorningHours = 1;
            int snowShovelingSaturdayMorningMinutes = 30;
            int snowShovelingSaturdayAfternoonHours = 0;
            int snowShovelingSaturdayAfternoonMinutes = 45;
            int totalTimeSnowShovelingMinutes = (snowShovelingSaturdayMorningHours * 60) + (snowShovelingSaturdayMorningMinutes) + (snowShovelingSaturdayAfternoonHours * 60) + (snowShovelingSaturdayAfternoonMinutes);
            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            decimal priceOfHotDog = .50M;
            decimal totalHotDogspurchased = 6M;
            decimal totalCostofHotDogs = priceOfHotDog * totalHotDogspurchased;
            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            decimal costOfPencil = .07M;
            decimal totalMoney = .50M;
            int numberOfPencilsAbleToPurchase = (int)(totalMoney / costOfPencil);          
            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int numberOfButterfliesSeen = 33;
            int numberOfButterfliesOrange = 20;
            int numberOfButterfliesRed = numberOfButterfliesSeen - numberOfButterfliesOrange;
            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            decimal moneyGivenToClerk = 1.00M;
            decimal costOfCandy = .54M;
            decimal changeReceived = moneyGivenToClerk - costOfCandy;
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int totalBackyardTrees = 13;
            int treesPlanted = 12;
            totalBackyardTrees += treesPlanted;

            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            const int hoursInDay = 24;
            int daysUntilGrandma = 2;
            int hoursUntilGrandma = daysUntilGrandma * hoursInDay;
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int piecesOfGumForCousins = 5;
            int numberOfCousins = 4;
            int totalGumForCousins = piecesOfGumForCousins * numberOfCousins;
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            decimal totalMoneyOfDan = 3.00M;
            decimal priceOfCandyBar = 1.00M;
            totalMoneyOfDan -= priceOfCandyBar;
            System.Console.WriteLine(totalMoneyOfDan);
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int numberOfPeopleInBoats = 3;
            int numberOfBoatsInLake = 5;
            int numberOfPeopleInLake = numberOfPeopleInBoats * numberOfBoatsInLake;
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int numberOfLegos = 380;
            int numberOfLostLegos = 57;
            numberOfLegos -= numberOfLostLegos;
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int numberOfMuffinsToBake = 83;
            int numberOfMuffinsBaked = 35;
            int numberOfMuffinsLeftToBake = numberOfMuffinsToBake - numberOfMuffinsBaked;
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int numberOfCrayonsWilly = 1400;
            int numberOfCrayonsLucy = 290;
            int numberOfCrayonsWillyMoreLucy = numberOfCrayonsWilly - numberOfCrayonsLucy;
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int numberOfStickersPerPage = 10;
            int numberOfPages = 22;
            int totalNumberOfStickers = numberOfStickersPerPage * numberOfPages;
            /*
            39. There are 100 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int numberOfCupcakes = 100;
            int numberOfChildren = 8;
            double equalSharesOfCupcakes = (double)(numberOfCupcakes) / (double)(numberOfChildren);
            System.Console.WriteLine(equalSharesOfCupcakes);

            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies, how many
            cookies will not be placed in a jar?
            */
            int numberOfCookies = 47;
            int numberOfCookiesHeldByJar = 6;
            int numberOfCookiesLeftOver = numberOfCookies % numberOfCookiesHeldByJar;
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received an equal number of croissants,
            how many will be left with Marian?
            */
            int numberOfCroissants = 59;
            int numberOfNeighbors = 8;
            int numberOfRemainingCroissants = numberOfCroissants % numberOfNeighbors;
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int numberOfOatmealCookies = 276;
            int numberOfCookiesPerTray = 12;
            int numberOfTrays = (int)System.Math.Ceiling((double)(numberOfOatmealCookies) / (double)(numberOfCookiesPerTray));
            System.Console.WriteLine(numberOfTrays);
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int numberOfPretzels = 480;
            int servingSizeOfPretzels = 12;
            int numberOfServings = numberOfPretzels / servingSizeOfPretzels;
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int numberOfCupcakesTaken = 51;
            int numberOfCupcakesPerBox = 3;
            int numberOfBoxesGiven = numberOfCupcakesTaken / numberOfCupcakesPerBox;
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int numberOfCarrotSticks = 74;
            int numberOfPeople = 12;
            int remainingCarrotSticks = numberOfCarrotSticks % numberOfPeople;
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int numberOfTeddyBears = 98;
            int numberOfBearsPerShelf = 7;
            int numberOfShelvesFull = numberOfTeddyBears / numberOfBearsPerShelf;
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int numberOfPictures = 480;
            int numberOfPicturesPerAlbum = 20;
            int numberOfAlbumsNeeded = numberOfPictures / numberOfPicturesPerAlbum;
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int numberOfCards = 94;
            int numberOfCardsPerBox = 8;
            int numberOfBoxesFull = (int)(numberOfCards / numberOfCardsPerBox);
            int numberOfRemainingCards = numberOfCards % numberOfCardsPerBox;
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int numberOfBooks = 210;
            int numberOfShelves = 10;
            int numberOfBooksPerShelf = numberOfBooks / numberOfShelves;
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            int numberOfCroissantsCristina = 17;
            int numberOfGuests = 7;
            double numberOfCroissantServings = (double)numberOfCroissantsCristina / (double)numberOfGuests;
            /*
            51. Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painters working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            */
           
            double totalTimeBill = 2.15;
            double totalTimeJill = 1.9;
            int squareFeetRoom = 168;
            int numberOfRooms = 5;
            double combinedRate = (squareFeetRoom / totalTimeBill) + (squareFeetRoom / totalTimeJill);
            double totalTimeCombined = (double)(squareFeetRoom * numberOfRooms) / combinedRate;       
            System.Console.WriteLine(totalTimeCombined);
            /*
            52. Create and assign variables to hold a first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold the full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period. Use "Grace", "Hopper, and "B" for the first name, last name, and middle initial.
            Example: "John", "Smith, "D" —> "Smith, John D."
            */
            string firstName = "Grace";
            string middleInitial = "B";
            string lastName = "Hopper";
            string fullName = lastName + ", " + firstName + " " + middleInitial + ".";
            System.Console.WriteLine(fullName);
            /*
            53. The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip as a whole number (integer) has been completed?
            */
            int totalTripDistance = 800;
            int distanceAlreadyTravelled = 537;
            int percentageOfTripComplete = (int)(((double)distanceAlreadyTravelled / (double)totalTripDistance) * 100);
            System.Console.WriteLine(percentageOfTripComplete);
        }
    }
}
