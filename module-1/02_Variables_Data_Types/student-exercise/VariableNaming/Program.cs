﻿using System;
using System.Transactions;

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
            Console.WriteLine(remainingNumberOfBirds);

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;
            Console.WriteLine(numberOfExtraBirds);



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int initialNumberOfRaccoons = 3;
            int raccoonsHomeForDinner = 2;
            int raccoonsLeftInTheWoods = initialNumberOfRaccoons - raccoonsHomeForDinner;
            Console.WriteLine(raccoonsLeftInTheWoods);
            /*
           4. There are 5 flowers and 3 bees. How many less bees than flowers?
           */
            int numberOfFlowers = 5;
            int numberOfBees = 3;
            int amountOfBees = numberOfFlowers -numberOfBees;
            Console.WriteLine(amountOfBees);
            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int lonelyPigeon = 1;
            int pigeonJoiningToEat = 1;
            int totalPigeonsEating = lonelyPigeon + pigeonJoiningToEat;
            Console.WriteLine(totalPigeonsEating);
            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int owlsSittingOnFence = 3;
            int owlsJoiningTheFence = 2;
            int totalOwlsSittingOnFence = owlsSittingOnFence + owlsJoiningTheFence;
            Console.WriteLine(totalOwlsSittingOnFence);
            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int beaversWorking = 2;
            int beaversGoingForASwim = 1;
            int beaversWorkingOnHome = beaversWorking - beaversGoingForASwim;
            Console.WriteLine(beaversWorkingOnHome);
            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int toucansSitting = 2;
            int toucansJoining = 1;
            int totalToucans = toucansSitting + toucansJoining;
            Console.WriteLine(totalToucans);
            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int squirrelsInTree = 4;
            int nutsInTree = 2;
            int totalSquirrels = squirrelsInTree - nutsInTree;
            Console.WriteLine(totalSquirrels);
            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            decimal hiltQuarter = .25m;
            decimal hiltDime = .10m;
            decimal hiltNickle = .05m;
            decimal hiltMoney = hiltQuarter + hiltDime + (hiltNickle * 2);
            Console.WriteLine(hiltMoney);
            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int brierMuffins = 18;
            int macadamsMuffins = 20;
            int flanneryMuffins = 17;
            int totalMuffinsFirstGrade = brierMuffins + macadamsMuffins + flanneryMuffins;
            Console.WriteLine(totalMuffinsFirstGrade);
            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            decimal hiltYoyo = .24m;
            decimal hiltWhistle = .14m;
            decimal hiltTotalMoneySpent = hiltYoyo + hiltWhistle;
            Console.WriteLine(hiltTotalMoneySpent);
            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */
            int hiltLargeMarshmallows = 8;
            int hiltSmallMarshmallows = 10;
            int totalMarshmallows = hiltSmallMarshmallows + hiltLargeMarshmallows;
            Console.WriteLine(totalMarshmallows);
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int hiltHouseSnow = 29;
            int hiltBrecknockSnow = 17;
            int snowForHiltHouse = hiltHouseSnow - hiltBrecknockSnow;
            Console.WriteLine(snowForHiltHouse);
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            int hiltStartingMoney = 10;
            int hiltToyTruck = 3;
            int hiltPencil = 2;
            int hiltRemainingMoney = hiltStartingMoney - hiltToyTruck - hiltPencil;
            Console.WriteLine(hiltRemainingMoney);
            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int marbleCollection = 16;
            int marblesLost = 7;
            int totalmarblecollection = marbleCollection - marblesLost;
            Console.WriteLine(totalmarblecollection);
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int meganSeashells = 19;
            int goalSeashellsMegan = 25;
            int meganNeedsToFind = goalSeashellsMegan - meganSeashells;
            Console.WriteLine(meganNeedsToFind);
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int bradBallonsTotal = 17;
            int bradRedBalloons = 8;
            int bradGreenBalloons = bradBallonsTotal - bradRedBalloons;
            Console.WriteLine(bradGreenBalloons);
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int startingBooksOnShelf = 38;
            int booksMartaPutOnShelf = 10;
            int totalBooksOnShelf = startingBooksOnShelf + booksMartaPutOnShelf;
            Console.WriteLine(totalBooksOnShelf);
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int numberOfLegsOnBee = 6;
            int numberPerBee = 8;
            int numberOfBeeLegs = numberOfLegsOnBee * numberPerBee;
            Console.WriteLine(numberOfBeeLegs);


            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            decimal hiltIceCreamConeCost = .99m;
            decimal hiltTwoIceCreamCone = 2;
            decimal hiltTotalCost = hiltTwoIceCreamCone * hiltIceCreamConeCost;
            Console.WriteLine(hiltTotalCost);

            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int hiltRocksNeededToComplete = 125;
            int hiltRocksCurrent = 64;
            int hiltRocksNeedd = hiltRocksNeededToComplete - hiltRocksCurrent;
            Console.WriteLine(hiltRocksNeedd);
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int hiltStartingMarbles = 38;
            int hiltLostMarbles = 15;
            int hiltTotalMarblesLeft = hiltStartingMarbles - hiltLostMarbles;
            Console.WriteLine(hiltTotalMarblesLeft);
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int hiltDrivingToConcert = 78;
            int hiltStoppingForGas = 32;
            int hiltMilesLeft = hiltDrivingToConcert - hiltStoppingForGas;
            Console.WriteLine(hiltMilesLeft);
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */
            int hiltHour = 60;
            int hiltMinMorning = hiltHour + 30;
            int hiltMinAfternoon = 45;
            int totalTimeShoveling = hiltMinMorning + hiltMinAfternoon;
            Console.WriteLine(totalTimeShoveling);
            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            int hiltHotdog = 6;
            decimal costOfHotdog = .50m;
            decimal costForHotdog = (hiltHotdog) * (decimal)costOfHotdog;
            Console.WriteLine(costForHotdog);
            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            int hiltMoneyForPencil = 50;
            int hiltCostForPencil = 7;
            int hiltAmountOfPencils = hiltMoneyForPencil / hiltCostForPencil;
            Console.WriteLine(hiltAmountOfPencils);
            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int hiltSawButterflies = 33;
            int hiltOrangeButterflies = 20;
            int hiltRedButterflies = hiltSawButterflies - hiltOrangeButterflies;
            Console.WriteLine(hiltRedButterflies);
            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            decimal changeGivenToClerk = 1.00m;
            decimal costOfCandy = .54m;
            decimal changeKateWillGetBack = changeGivenToClerk - costOfCandy;
            Console.WriteLine(changeKateWillGetBack);
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int treesInMarksYard = 13;
            int treesToBePlanted = 12;
            int totalTreesInBackyard = treesInMarksYard + treesToBePlanted;
            Console.WriteLine(totalTreesInBackyard);
            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int hoursInADay = 24;
            int daysUntilJoySeesGrandma = 2;
            int totalHoursUntilJoySeesGrandma = hoursInADay * daysUntilJoySeesGrandma;
            Console.WriteLine(totalHoursUntilJoySeesGrandma);
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int numberOfCousins = 4;
            int piecesOfGumPerCounsin = 5;
            int amountOfGumNeeded = numberOfCousins * piecesOfGumPerCounsin;
            Console.WriteLine(amountOfGumNeeded);
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            decimal moneyDanhas = 3.00m;
            decimal costForCandyBar = 1.00m;
            decimal amountOfMoneyBack = moneyDanhas - costForCandyBar;
            Console.WriteLine(amountOfMoneyBack);
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int boatsInTheLake = 5;
            int peopleInTheBoat = 3;
            int peopleOnTheLake = boatsInTheLake * peopleInTheBoat;
            Console.WriteLine(peopleOnTheLake);
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int ellenStartingLegos = 380;
            int ellenLostLegos = 57;
            int ellenLeftOverLegos = ellenStartingLegos - ellenLostLegos;
            Console.WriteLine(ellenLeftOverLegos);
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int arthurStartingMuffin = 35;
            int arthurGoalMuffins = 83;
            int arthurMuffinNeeded = arthurGoalMuffins - arthurStartingMuffin;
            Console.WriteLine(arthurMuffinNeeded);
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willyCrayons = 1400;
            int lucyCrayons = 290;
            int willyMoreCrayons = willyCrayons - lucyCrayons;
            Console.WriteLine(willyMoreCrayons);
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int pagesOfStickers = 22;
            int stickersPerPage = 10;
            int totalStickers = pagesOfStickers * stickersPerPage;
            Console.WriteLine(totalStickers);
            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int totalCupcakes = 96;
            int totalChildren = 8;
            int totalPerChild = totalCupcakes / totalChildren;
            Console.WriteLine(totalPerChild);
            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            int cookiesInJar = 47;
            int jarCanHoldCookies = 6;
            int cookiesLeft = cookiesInJar % jarCanHoldCookies;
            Console.WriteLine(cookiesLeft);
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            int croissantsPrepared = 59;
            int numberOfNeighbors = 8;
            int leftForMarian = croissantsPrepared % numberOfNeighbors;
            Console.WriteLine(leftForMarian);
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int cookiesOnATray = 12;
            int totalNumberOfCookies = 276;
            int numberOfTrays = totalNumberOfCookies / cookiesOnATray;
            Console.WriteLine(numberOfTrays);
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int totalBiteSizedPretzel = 480;
            int totalPerServing = 12;
            int numberOfServings = totalBiteSizedPretzel / totalPerServing;
            Console.WriteLine(numberOfServings);
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int numberOfLemonCupcakes = 53;
            int cakesLeftAtHome = 2;
            int boxesOfCupcakes = 3;
            int boxesused = (numberOfLemonCupcakes - cakesLeftAtHome) / boxesOfCupcakes;
            Console.WriteLine(boxesused);
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int carrotSticksPrepared = 74;
            int carrotSticksgiven = 12;
            int carrotsticksleft = carrotSticksPrepared % carrotSticksgiven;
            Console.WriteLine(carrotsticksleft);
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int totalTeddyBears = 98;
            int numberOfShelves = 7;
            int totalShelvesFilled = totalTeddyBears / numberOfShelves;
            Console.WriteLine(totalShelvesFilled);
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int albumHoldsPhotos = 20;
            int totalSusiePictures = 480;
            int totalAlbumsNeeded = totalSusiePictures / albumHoldsPhotos;
            Console.WriteLine(totalAlbumsNeeded);
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int totalTradingCards = 94;
            int boxHolds = 8;
            int boxedFilled = totalTradingCards / boxHolds;
            int unfilledBox = boxedFilled % boxHolds;
            Console.WriteLine(unfilledBox);
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int totalNumberOfBooks = 210;
            int booksOnShelf = 10;
            int susieBooksOnShelf = totalNumberOfBooks / booksOnShelf;
            Console.WriteLine(susieBooksOnShelf);
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            int cristinaCroissants = 17;
            int guestsAtCristina = 7;
            int croissantsAtGuests = cristinaCroissants / guestsAtCristina;
            Console.WriteLine(croissantsAtGuests);
            /*
                CHALLENGE PROBLEMS
            */

            /*
            Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painter working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            Challenge: How many days will it take the pair to paint 623 rooms assuming they work 8 hours a day?.
            */
            /*
            Create and assign variables to hold your first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold your full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period.
            Example: "Hopper, Grace B."
            */
            string firstName = " Vinny";
            string lastName = " Bucci";
            string middleInitial = " J";
            string fullname = lastName + ',' +  firstName +  middleInitial + '.';
            Console.WriteLine(fullname);

            /*
            The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip has been completed?
            Hint: The percent completed is the miles already travelled divided by the total miles.
            Challenge: Display as an integer value between 0 and 100 using casts.
            */
            int totalDistance = 800;
            int distancedAlreadyTravelled = 537;
            int distanceLeft = distancedAlreadyTravelled / totalDistance;
            
        }
    }
}
