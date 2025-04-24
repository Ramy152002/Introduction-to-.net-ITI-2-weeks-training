
//Console.WriteLine(weekDays.THURSDAY);
//Console.WriteLine((byte)weekDays.THURSDAY);
//Console.WriteLine(Convert.ToByte(weekDays.THURSDAY));
//Console.WriteLine(primaryColour.BLUE);
//Console.WriteLine((byte)primaryColour.BLUE);
//Console.WriteLine(primaryColour.RED.GetType());

//Console.WriteLine("(WeekDay)3: " + (weekDays)3);
//Console.WriteLine("(PrimaryColor)3: " + (primaryColour)1);
//enum weekDays : byte
//{
//    SATURDAY = 1,
//    SUNDAY = 2,
//    MONDAY = 3,
//    TUESDAY = 4,
//    WEDNESDAY = 5,
//    THURSDAY = 6,
//    FRIDAY = 7,
//}
//enum primaryColour
//{
//    RED,
//    GREEN,
//    BLUE
//}

//Operations (Arithmatic - comparison - assignment - logical operatiors 
//Arithmatic operators ( + - * / %)

//Console.Write("Enter the first number: ");

//string? firstNumber = Console.ReadLine();
//if (float.TryParse(firstNumber, out  float s))
//{
//    Console.WriteLine($"You entered: {s}");
//}
//else
//{
//    Console.WriteLine("Invalid input. Please enter a valid number.");
//}
//Console.Write("Enter the first     number: ");
//float firstNUmber = float.Parse(Console.ReadLine());
//Console.Write("Enter the second number: ");
//float secondNumber = Convert.ToSingle(Console.ReadLine());

// precedence : 1 , parentheses :2 , Multiplication  Division 3  , add sub 4
//Console.WriteLine(
//    $"addition\t: {firstNUmber + secondNumber}" +
//    $"\nsubtraction\t: {firstNUmber - secondNumber}" +
//    $"\nmultiplication\t: {firstNUmber * secondNumber}" +
//    $"\ndivision\t: {firstNUmber / secondNumber}" +
//    $"\nremainder\t: {firstNUmber%secondNumber}"
//    );
////assignment operator =
//int firstNumber = 800;
//Console.WriteLine(nameof(firstNumber)+ "\t\t: "+ firstNumber);

////addition assignment operator +=
//firstNumber += 200;
//Console.WriteLine($"firstNumber += 200\t: {firstNumber}");

////subtraction assignment -= 
//firstNumber -= 500;
//Console.WriteLine($"firstNumber -= 500;\t: {firstNumber}");

//// multiplication assignment *= 
//firstNumber *= 10;
//Console.WriteLine($"firstNumber *= 10;\t: {firstNumber}");

////division assignment /=
//firstNumber /= 5;
//Console.WriteLine($"firstNumber /= 5;\t: {firstNumber}");

////3. Invrement & decrement Operators
//int incrementTest1 = 9;
//int incrementTest2 = 5;
////prefix Increment operator 
//Console.WriteLine("Prefix Increment operator:");
//Console.WriteLine("inrementTest1\t: "+incrementTest1);
//Console.WriteLine("++inrementTest1\t: "+ ++incrementTest1);
//Console.WriteLine("inrementTest1\t: "+incrementTest1);
//Console.WriteLine("*******************");
////postfix increment 
//Console.WriteLine("Postfix Increment Operatoe: ");
//Console.WriteLine("incrementTest2\t: " + incrementTest2);
//Console.WriteLine("incrementTest2++:" + incrementTest2++);
//Console.WriteLine("incrementTest2\t: " + incrementTest2);


////prefix decrement operator 
//int decrementTest1 = 5;
//Console.WriteLine("Prefix decrement operator:");
//Console.WriteLine("derementTest1\t: " + decrementTest1);
//Console.WriteLine("--derementTest1\t: " + --decrementTest1);
//Console.WriteLine("derementTest1\t: " + decrementTest1);

////postfix decrement 
//int decrementTest2 = 10;
//Console.WriteLine("Postfix decrement Operatoe: ");
//Console.WriteLine("decrementTest2\t: " + decrementTest2);
//Console.WriteLine("decrementTest2--:" + decrementTest2--);
//Console.WriteLine("decrementTest2\t: " + decrementTest2);

// 4. comparison operator == != < > <= >= 

//int firstNo=7, secondNO=12;

//Console.WriteLine(

//    $"First Number \t:{firstNo}" +
//    $"\nSecond Number \t:{secondNO}" +
//    $"\nFirst number == second Number \t:{firstNo==secondNO}" +
//    $"\nFirst number != second Number \t:{firstNo!=secondNO}" +
//    $"\nFirst number > second Number \t:{firstNo>secondNO}" +
//    $"\nFirst number >= second Number \t:{firstNo>=secondNO}" +
//    $"\nFirst number < second Number \t:{firstNo<secondNO}" +
//    $"\nFirst number <= second Number \t:{firstNo<=secondNO}" +
//    $"\n*****************************************************"
//    );
//while (true) {
//    Console.Write("Enter your age :");
//    byte age = Convert.ToByte(Console.ReadLine());

//    Console.WriteLine($"Age\t:" + (age >= 18));

//    Console.Write("Enter your foriegn Language\t:");
//    char foreignLanguage = char.Parse(Console.ReadLine());
//    Console.WriteLine("English Foriegn Language\t: " + (foreignLanguage == 'E'));
//    Console.WriteLine("French Foriegn Language  \t: " + (foreignLanguage == 'F'));
//}


////5 logical operator 
//Console.WriteLine(
//    $"True  && true\t:{(true && true)}" +
//    $"\nTrue  && false\t:{(true && false)}" +
//    $"\nfalse && True \t:{(false && true)}"+
//    $"\nfalse && false \t:{(false && false)}"

//    );
//Console.WriteLine(
//    $"True  || true\t:{(true || true)}" +
//    $"\nTrue  || false\t:{(true || false)}" +
//    $"\nfalse || True \t:{(false || true)}" +
//    $"\nfalse || false \t:{(false || false)}"
//    );

//Console.WriteLine("!True \t\t:"+!true);
//Console.WriteLine("!false \t\t:"+!false);

//Console.WriteLine("***********************************");
//for(; ; )
//{
//    Console.Write("Enter your age :");
//    byte age = Convert.ToByte(Console.ReadLine());

//    Console.WriteLine($"Age\t:" + (age >= 21&&age<=40));

//    Console.Write("Enter your foriegn Language (E/F)\t:");
//    char foreignLanguage = char.Parse(Console.ReadLine());
//    Console.WriteLine("Foriegn Language: " + ((foreignLanguage == 'E')||(foreignLanguage=='F')));

//    Console.Write("Have you ever applied for this job before (y/n): ");
//    char appliedBefore = char.Parse(Console.ReadLine());
//    Console.WriteLine("New applican: " + !(appliedBefore == 'y' )+"\n");

//}

// Function & methods in oop
////method definaion = type + method signation 
//float SumTwoNumber(float firstNo, float secondNo)
//{
//    return firstNo+ secondNo;
//}
//float addition = SumTwoNumber(5, 55);
//Console.WriteLine("SumTwoNumber 6+94\t:"+SumTwoNumber(6,94));

//void GreatingVisitor()
//{
//    Console.WriteLine("Hi Ramy");
//}

//decimal CalculatPrice(decimal cost,decimal profitRatio)
//{

//return cost+ cost*profitRatio + cost*0.30m;
//}


//Console.WriteLine("CalculatPrice(100m,10m)\t:" + CalculatPrice(1000m, 0.30m));
//Console.WriteLine("CalculatPrice(100m,10m)\t:" + CalculatPrice(2000m, 0.20m));
//Console.WriteLine("CalculatPrice(100m,10m)\t:" + CalculatPrice(6000m, 0.10m));

//GreatingVisitor();


//void GreatUser(string username) =>Console.WriteLine("Hi "+username);
//GreatUser("Ramy");

////named arguments
//string GetFullName(string firstName, string lastName)=>firstName+" "+lastName;

//string fullName = GetFullName(lastName: "Hany", firstName: "Ramy");
//Console.WriteLine($"{nameof(fullName)}\t:{fullName}");

////optional parameters 
//void ShowDetails(string fullName, string position, string country = "Egypt")
//{
//    Console.WriteLine($"Full Name\t: {fullName}" +
//        $"\nPosition\t:{position}" +
//        $"\nCountry\t\t:{country}");
//}

//ShowDetails(fullName, "Back End");
//ShowDetails("Hassan Ahmed", "Front End","USA");

////Expression-bodied Method 
//void GreatCustomer(string customerName) => Console.WriteLine($"Hi, {customerName} \nWelcome to our company");
//GreatCustomer("Peter");

//float SumTwoNumber(float firstNumber, float secondNumber)=>firstNumber+secondNumber;
//Console.WriteLine("50+66= "+SumTwoNumber(50,66));
//Console.WriteLine("90+60= "+SumTwoNumber(90,60));

//int currentHour = DateTime.Now.Hour;

//if (currentHour<9||currentHour>17) Console.WriteLine("Work is between 9 and 17");
//if (currentHour <= 17 && currentHour >= 9) Console.WriteLine("Welcome to Sunrise");
//else Console.WriteLine("Try again between 9 and 5 pm");
//if (currentHour >= 4 && currentHour < 12) Console.WriteLine("Good morning");
//else if (currentHour >= 12 && currentHour < 18) Console.WriteLine("Good afternoon");
//else Console.WriteLine("Good evening");

//ternary/conditional operator 

//byte currentHour = 11;
//{
//    //string message1 = currentHour <= 17 && currentHour >= 9 ? "Welcome to Sunrise" : "Try again between 9 and 5 pm";
//    //string message2 = currentHour >= 4 && currentHour < 12 ? "Good morning" :
//    //                                                         currentHour >= 12 && currentHour < 18 ? "Good afternoon" : "Good evening";
//    //Console.WriteLine(message1);
//    //Console.WriteLine(message2);
//}


////switch case
//for (; ; )
//{

//    Console.Write("Where are you from? ");
//    string country = Console.ReadLine();
//    float discountRatio;

//    switch (country)
//    {
//        case "Egypt":
//            discountRatio = .30f;
//            break;
//        case "Libya":
//        case "Mauritania":
//        case "Tunisia":
//        case "Algeria":
//        case "Morocco":

//            discountRatio = 0.2f;
//            break;
//        default:
//            discountRatio = 0.10f;
//            break;
//    }
//    Console.WriteLine("Discount ration = " + discountRatio.ToString("P0"));

//}

////string transportation, departureTime;
////for (; ; )
////{
////    Console.Write("Enter transportaion (Bus, Train):");
////    transportation = Console.ReadLine();

////    Console.Write("Enter departure time (3PM, 7PM)\t:");
////    departureTime = Console.ReadLine();

////    switch (transportation)
////    {
////        case "Bus":
////            switch (departureTime)
////            {
////                case "3PM":
////                    Console.WriteLine("150 EGP");
////                    break;

////                case "7PM":
////                    Console.WriteLine("170 EGP");
////                    break;

////                default:
////                    break;
////            }
////            break;

////        case "Train":
////            switch (departureTime)
////            {
////                case "3PM":
////                    Console.WriteLine("200 EGP");
////                    break;

////                case "7PM":
////                    Console.WriteLine("250 EGP");
////                    break;

////                default:
////                    break;
////            }
////            break;


////    }
////}

//for (int i = 0; i < 5; i++)
//    Console.WriteLine($"{i+1}- Welcome to for loop. Index: {i}");

//Console.WriteLine();

//for (int i = 1; i <= 5; i++)
//    Console.WriteLine($"{i }- Welcome to for loop. Index: {i-1}");

//Console.WriteLine();

//for (int i = 5; i >=1; i--)
//    Console.WriteLine($"{i}- Welcome to for loop. Index: {i - 1}");

//Console.WriteLine();

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("i: "+i);
//    if (i == 3) break;
//}

//Console.WriteLine();

//for (int i = 1; i <= 10; i++)
//{
//    if (i % 3 == 0)
//        continue;
//       Console.WriteLine("i: "+i);
//}

//for (int i = 0, j = 10; i + j <= 20; i++, j++)
//{
//    Console.WriteLine($"{i}+{j}= {i + j}");
//}
//Console.WriteLine(); 

//for (int i = 1; i <= 12; i++)
//{
//    Console.WriteLine($"\nMultiplcation table {i}:");
//    for (int j = 1; j <= 12; j++)
//	{
//        Console.WriteLine($"{i} * {j} = {i*j}");
//    }
//}

////string initialization and continuance condition
//string allProducts = string.Empty;
//Console.WriteLine("Enter your product names (when you finished enter done):");

//for(string product = string.Empty; product != "done";)
//{
//    product=Console.ReadLine();
//    if (product =="done")continue;
//    allProducts += "\n- "+product;
//}

//Console.WriteLine($"All products : {allProducts}");

#region session 5

// session 5################################################################################
//Console.Write("Enter the number of products:");
//byte noOfProducts = byte.Parse(Console.ReadLine());

//string productName,allProduct=string.Empty;

//for (int i = 0; i < noOfProducts; i++)
//{
//    Console.Write($"Enter product number {i+1}'s name: ");
//    productName = Console.ReadLine();

//    Console.Write($"Enter {productName}'s number of customers: ");
//byte numberOfCustomers=byte.Parse(Console.ReadLine());
//    string customers =string.Empty;

//    // inier loop 
//    for (int j = 0; j < numberOfCustomers; j++)
//    {
//        Console.Write($"Enter customer number {j+1}'s name: ");
//        string customer = Console.ReadLine();
//        customers += $"\t- {customer}\n";
//    }
//    Console.WriteLine();
//    allProduct += $"\n{i + 1}- {productName}:\n{customers}";
//}

//Console.WriteLine(allProduct);


//Console.ReadLine(Console.Out);

//string iti = "MCIT ITI";
//foreach (var item in iti)
//    Console.WriteLine($"\t|{item}|");

//string password = string.Empty;
//while (password != "Abc72%")
//{
//    Console.WriteLine("Enter your password: ");
//    password = Console.ReadLine();
//}
//Console.WriteLine("Welcome to Sunrise");

//char answer = '\0';// empty char 
//do
//{
//    Console.WriteLine("trying to connect.....");
//    Thread.Sleep(1000);
//    Console.Write("Connection Failed.\nRetry?(y/n) ");
//    answer =char.Parse(Console.ReadLine());
//} while (answer=='y');

//int [] Week1Production = new int[5];
//Week1Production[0]=21;
//Week1Production[1]=11;
//Week1Production[2]=51;
//Week1Production[3]=41;
//Week1Production[4]=31;

//int[] Week2Production = new int[5] { 22, 12, 52, 42, 32 };
//int[] Week3Production =  { 23, 13, 53, 43, 33 };
//int[] Week4Production = new int[] { 24, 14, 54, 44, 34 };

//Console.WriteLine($"Week2Production[2]: "+ Week2Production[2]);
//Week2Production[2] = 74;
//Console.WriteLine($"Week2Production[2]: "+ Week2Production[2]);
//Console.WriteLine("Week4Production "+ Week4Production);
//Console.WriteLine("Week4Production.Length: "+ Week4Production.Length);

//for (int i = 0; i < Week1Production.Length; i++) Console.WriteLine($"Week4Production[{i}]: {Week4Production[i]}");

//foreach (int element in Week4Production)
//    Console.WriteLine(element);

//int [] week5Production = { 25, 45, 55, 45, 35 };

//Console.WriteLine($"week5Production.contains(55) : {week5Production.Contains(55)}");
//Console.WriteLine($"week5Production.contains(66) : {week5Production.Contains(66)}");

//Console.WriteLine($"Array.IndexOf(week5Production, 45): {Array.IndexOf(week5Production, 45)}");
//Console.WriteLine($"Array.IndexOf(week5Production, 75): {Array.IndexOf(week5Production, 75)}");

//Console.WriteLine($"Array.LastIndexOf( week5Production,45): {Array.LastIndexOf(week5Production, 45)}");
//Console.WriteLine($"Array.LastIndexOf( week5Production,75): {Array.LastIndexOf(week5Production, 75)}");

//Array.Clear(week5Production, 1, 3);

//foreach (int element in week5Production) Console.WriteLine(element);


//int[] Week1Production = { 21, 11, 51, 4, 131 };
//int[] Week2Production = { 22, 12, 52, 42, 32 };
//int[] Week3Production =  { 23, 13, 53, 43, 33 };
//int[] Week4Production = { 24, 14, 54, 44, 34 };

//int[] janMonthProduction = new int[20];

//Array.Copy(Week1Production,0,janMonthProduction, 0, Week1Production.Length);
//Array.Copy(Week2Production,0,janMonthProduction, 5, Week2Production.Length);
//Array.Copy(Week3Production,0,janMonthProduction, 10, Week3Production.Length);
//Array.Copy(Week4Production,0,janMonthProduction, 15, Week4Production.Length);

//Console.WriteLine("Jan month production : ");
//foreach (int element in janMonthProduction) Console.WriteLine(element);


//int[] sales = { 200, 700, 300, 500, 100 };
//Console.WriteLine("Before sort: ");

//foreach (var item in sales) Console.WriteLine(item);

//Array.Sort(sales ,1,3);
//Console.WriteLine("After sort: ");
//foreach (var item in sales) Console.WriteLine(item);

//Array.Reverse(sales,1,3);

//Console.WriteLine("After reverse: ");
//foreach (var item in sales) Console.WriteLine(item);
#endregion

#region session 6
//session 6

#region task ArrayList & Array
//using System.Collections;
//ArrayList scores = new ArrayList() { 75, 98, "Eighty-two" };
//Console.WriteLine($"scores[1]=93: {scores[1]}");
//scores[1] = 93;
//Console.WriteLine($"scores[1]=93: {scores[1]}");

//Console.WriteLine("scores.Count: "+scores.Count );

//Console.WriteLine();
//for (int i = 0; i < scores.Count; i++)
//    Console.WriteLine($"scores[{i}]: {scores[i]}");

//Console.WriteLine();
//foreach (var item in scores) Console.WriteLine(item);

#endregion
#region example arraylist
//using System.Collections;

/////
//ArrayList branches = new ArrayList() { "Egypt", "Oman", "Kuwait", "Bahrain" };

//branches.Add("KSA");
//branches.Add("USA");
//branches.Add("Morocco");

//for (int i = 0; i < branches.Count; i++)
//    Console.WriteLine($"branches[{i}]: {branches[i]}");

#endregion
#region Queue
//Queue <string> waitingCustomers = new Queue<string>();
//waitingCustomers.Enqueue("United Trade");
//waitingCustomers.Enqueue("Stars Schools");
//waitingCustomers.Enqueue("Golden Rays Hospitals");

//foreach(var customer in waitingCustomers) Console.WriteLine(customer);
//Console.WriteLine();

//waitingCustomers.Dequeue();
//Console.WriteLine("After first dequeue");
//foreach (string customer in waitingCustomers) Console.WriteLine("\t-"+customer);
//Console.WriteLine();

//waitingCustomers.Dequeue();
//Console.WriteLine("After second dequeue");
//foreach (string customer in waitingCustomers) Console.WriteLine("\t-"+customer);

#endregion
#region stack (push & pop)
//Stack<string> unreadMails = new Stack<string>();
//unreadMails.Push("1. Ahmed Ali");
//unreadMails.Push("2. Ramy Hany");
//unreadMails.Push("3. Wael Omar");

//foreach (string mail in unreadMails) Console.WriteLine(mail);

//unreadMails.Pop();
//Console.WriteLine("After first pop: ");
//foreach (string mail in unreadMails) Console.WriteLine($"\t-{mail}");

//unreadMails.Pop();
//Console.WriteLine("After second pop: ");
//foreach (string mail in unreadMails) Console.WriteLine($"\t-{mail}");

#endregion
#region List list اكتر collection يستخدم ف ال .net 
//using System.Collections;

//List<string> products = new List<string>() { "SIS", "ERP", "CRM" };
//products.Add("LMS");
//products.Add("HIS");

////adding a list to list
//List<string> decemberProducts = new List<string>() { "ABC", "DEF" };
//products.AddRange(decemberProducts);

////adding an arraylist to list is ERROR
////ArrayList productsList = new ArrayList() { "kljl" ,"kj"};
////products.AddRange(productsList);

////adding an array to list 
//string[] januaryProducts = { "GHI", "JKL" };
//products.AddRange(januaryProducts);

//foreach (string product in products) Console.WriteLine(product);

//// play with indexing 
//Console.WriteLine($"products[2]: {products[2]}");
//products[2] = "CRMS";
//Console.WriteLine($"products[2]: {products[2] }");

//// count property and count method
//Console.WriteLine($"products.Count: {products.Count}");
//Console.WriteLine($"products.Count(): {products.Count()}");

//Console.WriteLine( );
//for ( int i = 0; i < products.Count; i++ ) Console.WriteLine( $"products[{i}]: {products[i]}" );

#endregion
#region convert List to Array and vise versa
//// convert List to Array
//List<string> employeesList = new List<string>() { "Ramy Hany", "Omar Wael", "Hassan Abbas" };
//string[]employeesArray = employeesList.ToArray();
//foreach (string employee in employeesArray) Console.WriteLine(employee);
//Console.WriteLine();

//// convert Array to List 
//string[] contienetArray = { "Africa", "Asia", "Europe", "North America", "South America", "Antarctica" };
//List<string> contienetList =contienetArray.ToList();
//foreach (string continent in contienetList) Console.WriteLine(continent);
//Console.WriteLine();

//// contains 
//Console.WriteLine($"continentList.Contains(\"Europe\"): {contienetList.Contains("Europe")}");
//Console.WriteLine($"continentList.Contains(\"Red Sea\"): {contienetList.Contains("Red Sea")}");
//Console.WriteLine();

////  IndexOf
//Console.WriteLine($"continentList.IndexOf(\"Europe\"): {contienetList.IndexOf("Europe")}");
//Console.WriteLine($"continentList.Indexof(\"Red Sea\"): {contienetList.IndexOf("Red Sea")}");
//Console.WriteLine();

//// LastIndexOf 
//Console.WriteLine($"continentList.LastIndexOf(\"Europe\"): {contienetList.LastIndexOf("Europe")}");
//Console.WriteLine($"continentList.LastIndexOf(\"Red Sea\"): {contienetList.LastIndexOf("Red Sea")}");
//Console.WriteLine();

////remove 
//contienetList.Remove("North America");
//Console.WriteLine("ContienntList after removing \"North America\"");
//foreach (string continent in contienetList) Console.WriteLine(continent);
//Console.WriteLine();

////RemoveAt 
//contienetList.RemoveAt(1);
//Console.WriteLine("contienetList.RemoveAt(1)");
//foreach (string continent in contienetList) Console.WriteLine(continent);
//Console.WriteLine();

////RemoveRange
//contienetList.RemoveRange(1, 2);
//Console.WriteLine($"contienetList.RemoveRange(1, 2):");
//foreach (string continent in contienetList) Console.WriteLine(continent);
//Console.WriteLine();

////clear
//contienetList.Clear();//remove not reset to defualt 
//Console.WriteLine(nameof(contienetList)+".clear(): ");
//foreach (string continent in contienetList) Console.WriteLine(continent);
//Console.WriteLine();

////count
//Console.WriteLine($"{nameof(contienetList)}.Count(): {contienetList.Count()}");

#endregion
#region Dicionary (key-value pair kvp)
//Dictionary<int, string> branches = new Dictionary<int, string>()
//{
//    {1010,"Kuwait" },
//    {1020,"Bahrain" },
//    {2010,"Thailand" },
//    {2020,"China" }

//};
//// Dictionary add
//branches.Add(3010, "England");
//branches.Add(3020, "France");

//Console.WriteLine($"branches[1020]: {branches[1020]}");
//branches[1020] = "Oman";
//Console.WriteLine($"branches[1020]: {branches[1020]}");

//foreach (var branch in branches) Console.WriteLine(branch.Key+": "+branch.Value);

//// containsKey
//Console.WriteLine($"branches.ContainsKey(1020): {branches.ContainsKey(1020)}");
//Console.WriteLine($"branches.ContainsKey(1030): {branches.ContainsKey(1030)}");

////containsValue
//Console.WriteLine($"branches.ContainsValue(\"Thailand\"): {branches.ContainsValue("Thailand")}");
//Console.WriteLine($"branches.ContainsValue(\"Japan\"): {branches.ContainsValue("Japan")}");

////remove 
//branches.Remove(3010);
//Console.WriteLine($"After branches.Remove(3010)");
//foreach (var branch  in branches) Console.WriteLine(branch);

#endregion
#region char functions
//char characterM = 'M';
//Console.WriteLine($"char.IsWhiteSpace(characterM)\t\t:{char.IsWhiteSpace(characterM)}" +
//    $"\nchar.IsUpper(characterM)\t\t:{char.IsUpper(characterM)}" +
//    $"\nchar.IsLower(characterM)\t\t:{char.IsLower(characterM)}" +
//    $"\nchar.IsDigit(characterM)\t\t:{char.IsDigit(characterM)}" +
//    $"\nchar.IsLetter(characterM)\t\t:{char.IsLetter(characterM)}" +
//    $"\nchar.IsLetterOrDigit(characterM)\t:{char.IsLetterOrDigit(characterM)}" +
//    $"\nchar.IsNumber(characterM)\t\t:{char.IsNumber(characterM)}" +
//    $"\nchar.IsPunctuation(characterM)\t\t:{char.IsPunctuation(characterM)}" +
//    $"\nchar.IsSeparator(characterM)\t\t:{char.IsSeparator(characterM)}" );

#endregion
#region string function
//string iti = "Information Technology institute";
//Console.WriteLine($"iti: {iti}");
//Console.WriteLine();

//// startwith
//Console.WriteLine($"iti.StartsWith('I'): {iti.StartsWith('I')}");
//Console.WriteLine($"iti.StartsWith(\"In\"): {iti.StartsWith("In") }");
//Console.WriteLine($"iti.StartsWith(\"It\"): {iti.StartsWith("It") }");
//Console.WriteLine();

////Endswith
//Console.WriteLine($"iti.EndsWith(\"te\"): {iti.EndsWith("te")}");
//Console.WriteLine($"iti.EndsWith(\"gy\"): {iti.EndsWith("gy")}");
//Console.WriteLine();

////contains
//Console.WriteLine($"iti.Contains(\"Tech\"): {iti.Contains("Tech")}");
//Console.WriteLine($"iti.Contains(\"cs\"): {iti.Contains("cs")}");
//Console.WriteLine();

////indexOf
//Console.WriteLine($"iti.IndexOf(\'o\'): {iti.IndexOf('o')}");
//Console.WriteLine($"iti.IndexOf(\"o\"): {iti.IndexOf("o")}");
//Console.WriteLine($"iti.IndexOf(\'z\'): {iti.IndexOf('z')}");
//Console.WriteLine($"iti.IndexOf(\"z\"): {iti.IndexOf("z")}");
//Console.WriteLine();

////LastIndexOf
//Console.WriteLine($"iti.LastIndexOf('o'): {iti.LastIndexOf('o')}");
//Console.WriteLine($"iti.LastIndexOf(\"o\"): {iti.LastIndexOf("o")}");
//Console.WriteLine($"iti.LastIndexOf('w'): {iti.LastIndexOf('w')}");
//Console.WriteLine($"iti.LastIndexOf(\"w\"): {iti.LastIndexOf("w")}");


#endregion
#endregion session 6




#region session 7
#region String Trim and isNulorEmpty isNullorWhitespacw
//string cs = "        Computer Science         ";
//Console.WriteLine(
//    $"cs\t\t\t\t: |{cs}|" +
//    $"\ncs.TrimStart()\t\t\t: |{cs.TrimStart()}|" +
//    $"\ncs.TrimEnd()\t\t\t: |{cs.TrimEnd()}|" +
//    $"\ncs.TrimStart().TrimEnd()\t: |{cs.TrimStart().TrimEnd()}|" +
//    $"\ncs.Trim()\t\t\t: |{cs.Trim()}|"
//    );

//string strNull = null;
//string strEmpty = string.Empty;
//string strSpaces = "          ";
//string strCSharp = "c#";

//Console.WriteLine(
//$"\nstring.IsNullOrEmpty(strNull)\t\t: {string.IsNullOrEmpty(strNull)}" +
//$"\nstring.IsNullOrEmpty(strEmpty)\t\t: {string.IsNullOrEmpty(strEmpty)}" +
//$"\nstring.IsNullOrEmpty(strSpaces)\t\t: {string.IsNullOrEmpty(strSpaces)}" +
//$"\nstring.IsNullOrEmpty(strSpaces.Trim())\t: {string.IsNullOrEmpty(strSpaces.Trim())}" +
//$"\nstring.IsNullOrEmpty(strCSharp)\t\t: {string.IsNullOrEmpty(strCSharp)}"
//);


//Console.WriteLine(
//$"\nstring.IsNullOrWhiteSpace(strNull)\t: {string.IsNullOrWhiteSpace(strNull)}" +
//$"\nstring.IsNullOrWhiteSpace(strEmpty)\t: {string.IsNullOrWhiteSpace(strEmpty)}" +
//$"\nstring.IsNullOrWhiteSpace(strSpaces)\t: {string.IsNullOrWhiteSpace(strSpaces)}" +
//$"\nstring.IsNullOrWhiteSpace(strCSharp)\t: {string.IsNullOrWhiteSpace(strCSharp)}"
//);



#endregion
#region string and substring toupper toLower Replace Substring split ToCharArray

//string iti = "MCIT Information Technology Institute";
//string str1 = "Good Morning";
//string str2 = "good morning";

//Console.WriteLine(
//$"iti\t\t\t\t\t: {iti}" +
//$"\niti.ToUpper()\t\t\t\t: {iti.ToUpper()}" +
//$"\niti.ToLower()\t\t\t\t: {iti.ToLower()}" +
//$"\nstr1\t\t\t\t\t: {str1}" +
//$"\nstr2\t\t\t\t\t: {str2}" +
//$"\nstr1==str2\t\t\t\t\t:{str1==str2}" +
//$"\nstr1.ToLower()==str2.ToLower()\t\t\t\t:{str1.ToLower()==str2.ToLower()}"+
//$"\nstr1.ToLower()==str2.ToLower()\t\t\t\t:{str1.ToLower()==str2.ToLower()}" +
//$"\niti.Replace(' ','-')\t\t:{iti.Replace(' ','-')}" +
//$"\niti.Replace('o','O')\t\t:{iti.Replace('o','O')}" +
//$"\niti.Replace(\"In\",\"iN\")\t\t:{iti.Replace("In","iN")}" +
//$"\niti.Substring(0,9)\t\t:{iti.Substring(0,9)}"+
//$"\niti.Substring(17,4)\t\t:{iti.Substring(17,4)}"

//    );
//string []splittedIti = iti.Split(' ');
//Console.WriteLine($"splittedIti:");
//foreach (string str in splittedIti) Console.WriteLine($"\t-{str}");

//char[] itiChars=iti.ToCharArray();
//Console.WriteLine("itiChars:");
//foreach (char ch in itiChars) Console.WriteLine($"\t-{ch}");

#endregion
#region escaping string concatenation+ and interpolation$ verbatim@ Raw string """

//escape sequence
//Console.WriteLine("ABC\nDEF\tGHI\"JKL\\MNO");
//string firstName = "Ramy";
//string lastName = "Hany";

////string concatenation
//Console.WriteLine("1. String concatenation:");
//string fullName = "Full Name: "+firstName + " " + lastName;
//Console.WriteLine(fullName);

////string Interpolation 
//Console.WriteLine("\n2. String Interpolation: ");
//string fullNameInterpolation =$"Full Name: {firstName} {lastName}";
//Console.WriteLine(fullNameInterpolation);

////3. verbatim string
//Console.WriteLine("\n3. Verbatim String:");
//string normalStringPath1 = "E:\\Projects\\Docu\\nments\\Rep\norts\\report\"52\".pdf";
//Console.WriteLine("\nnormalStringPath1:\n");
//Console.WriteLine(normalStringPath1);

//string verbatimPath1 = @"E:\Projects\Docu
//nments\Rep
//orts\report""52"".pdf";
//Console.WriteLine("\nverbatimPath1\n");
//Console.WriteLine(verbatimPath1);

////Raw string """  """
//Console.WriteLine("\n4. Raw String:\n");
//string rawStringPath1 = """
//    E:\Projects\Docu
//    nments\Rep
//    orts\report"52".pdf
//    """;
//Console.WriteLine("rawStringPath1:\n");
//Console.WriteLine(rawStringPath1);




#endregion


#region mutable (changeable) vs immutable( unchangeable)

//using System.Text;

//StringBuilder sbAnoutCompany = new StringBuilder();
//sbAnoutCompany.Append('(', 5);
//sbAnoutCompany.Append('*', 10);
//sbAnoutCompany.Append("Moon Tech");
//sbAnoutCompany.Append('*', 10);
//sbAnoutCompany.Append(')', 5);
//sbAnoutCompany.AppendLine();
//sbAnoutCompany.AppendLine("Our Products:");
//sbAnoutCompany.AppendLine("-SIS");
//sbAnoutCompany.AppendLine("-ERP");
//sbAnoutCompany.AppendLine("-MIS");
//sbAnoutCompany.AppendLine("-LMS");
//sbAnoutCompany.AppendLine("-HRMS");
//Console.WriteLine(sbAnoutCompany);
//Console.WriteLine();

//sbAnoutCompany.Replace('-', '=');
//sbAnoutCompany.Insert(15, ' ');
//sbAnoutCompany.Insert(25, ' ');
//sbAnoutCompany.Remove(10, 5);
//sbAnoutCompany.Remove(21, 5);

//Console.WriteLine(sbAnoutCompany);

#endregion
#region oop

//using session_3;

//Vehicle vehicle1 = new Vehicle();
//vehicle1.SetColor("White");
//Console.WriteLine($"vehicle1.GetColor()\t:{vehicle1.GetColor()}");
//Console.WriteLine();

//Vehicle vehicle2 = new Vehicle();
//vehicle2.SetColor("Yellow");
//Console.WriteLine($"vehicle2.GetColor()\t:{vehicle2.GetColor()}");

#endregion
#region oop 2

//using session_3;

//Vehicle vehile1 = new Vehicle();
//Console.WriteLine(nameof(vehile1));
//vehile1.Color = "White";
//Console.WriteLine("Vehicle1.Color: "+vehile1.Color);
//Console.WriteLine();

//Vehicle vehile2 = new Vehicle();

//Console.WriteLine(nameof(vehile2));
//vehile2.Color = "Yellow";
//Console.WriteLine("Vehicle2.Color: "+vehile2.Color);
//Console.WriteLine();



#endregion
#endregion



#region session 8

#region Encapsulation 
//using session_3;

//Vehicle vehicle1 = new Vehicle();
//Console.WriteLine(nameof(vehicle1) + ":");
//vehicle1.Color = "YELLOW";
//Console.WriteLine("Vehicle1.Color: " + vehicle1.Color);

//Console.WriteLine();
//Vehicle vehicle2 = new Vehicle();
//Console.WriteLine(nameof(vehicle2) + ":");
//vehicle2.Color = "White";
//vehicle2.Model = "Tiger";
//vehicle2.Length = 197.5f;
//vehicle2.Width = 170.5f;
//vehicle2.Height = 166.5f;
//Console.WriteLine($"vehicle2.ShowSpecification()\t: ");
//Console.WriteLine( vehicle2.ShowSpecification());
//Console.WriteLine($"\r\nvehicle2.ShowSpecification(\"FULL\"):");
//Console.WriteLine( vehicle2.ShowSpecification("FULL"));
//Console.WriteLine($"\r\nvehicle2.ShowSpecification(\"Brief\"):");
//Console.WriteLine( vehicle2.ShowSpecification("Brief"));

//Console.WriteLine();
//Console.WriteLine("\nVehicle3: ");
//Vehicle vehicle3 = new Vehicle("Tornado", "Silver", 215, 190f, 187.5f);

//Console.WriteLine($"vehicle3.ShowSpecification()\t: ");
//Console.WriteLine( vehicle3.ShowSpecification());
//Console.WriteLine($"\r\nvehicle3.ShowSpecification(\"FULL\"):");
//Console.WriteLine( vehicle3.ShowSpecification("FULL"));
//Console.WriteLine($"\r\nvehicle3.ShowSpecification(\"Brief\"):");
//Console.WriteLine(vehicle3.ShowSpecification("Brief"));
#endregion
#region inherance truck from vehicle and polymorpism
//using session_3;

//using session_3;

//Truck truck = new Truck();
//Truck.Manufacturer = "Sunshne";
//truck.Model = "Eagle";
//truck.Color = "Blue";
//truck.Length = 550f;
//truck.Width = 325f;
//truck.Height = 350f;
//truck.BoxVolume = 3300f;
//Console.WriteLine($"truck.ShowSpecification()\t: ");
//Console.WriteLine(truck.ShowSpecification());
//Console.WriteLine($"\r\ntruck.ShowSpecification(\"FULL\"):");
//Console.WriteLine(truck.ShowSpecification("FULL"));
//Console.WriteLine($"\r\ntruck.ShowSpecification(\"Brief\"):");
//Console.WriteLine(truck.ShowSpecification("Brief"));

//Truck truck2 = new Truck("Scorpion", "Black", 255f, 155.56f, 147.9f, 245.6f);
//Console.WriteLine("**************************************************");
//Console.WriteLine($"truck2.ShowSpecification()\t: ");
//Console.WriteLine(truck2.ShowSpecification());
//Console.WriteLine($"\r\ntruck2.ShowSpecification(\"FULL\"):");
//Console.WriteLine(truck2.ShowSpecification("FULL"));
//Console.WriteLine($"\r\ntruck2.ShowSpecification(\"Brief\"):");
//Console.WriteLine(truck2.ShowSpecification("Brief"));

//Console.WriteLine("truck2.ToString():");
//Console.WriteLine(truck2.ToString());
#endregion

#endregion


#region session 9 monday
#region partial classes

//using session_3;

//Customer customer = new Customer();
//customer.Id = 1;
//customer.Name = "Golden Foods";
//customer.Email = "info@goldenfoods.com";
//customer.Address = "Cairo, 37 Ahmed Farid st.";

//Console.WriteLine($"customer.ToString(): ");
//Console.WriteLine(customer.ToString());


#endregion

//using session_3;

//Truck truck3 = new Truck()
//{
//    Model = "Leopard",
//    Color = "Black",
//    Length = 120.0f,
//    Width = 200.0f,
//    Height = 250.0f,
//    BoxVolume = 300.0f
//};
//Console.WriteLine($"truck3.ShowSpecification(): " +
//    $"{truck3.ShowSpecification()}");

#region struct

//using session_3;

//productCard product1Card = new productCard("ABC", 7, "Blue");
//Console.WriteLine($"product1Card.GetCard():" +
//    $"\n{product1Card.GetCard()}");
#endregion

#region Anonymous object

// بدل م اعمل struct or class for just an visited object 
//using session_3;

//var visitor = new { Name = "Ramy Hany", Title = "Mr.",
//                    Greeting = "Your visit is honor to our company!" };

//Console.WriteLine($"Hello, {visitor.Title} {visitor.Name}, " +
//    $"\n{visitor.Greeting}");


#endregion
#region
//using session_3;

//Car car1 = new Car();
//Console.WriteLine($"{nameof(car1)} :");
//car1.Color = "Yellow";
//Console.WriteLine("car.Color: "+car1.Color);

//Console.WriteLine();

//Car car2 = new Car();
//Console.WriteLine(nameof(car2)+":");
//car2.Color = "White";
//car2.Model = "Tiger";
//car2.Length = 197.5f;
//car2.Width = 170.5f;
//car2.Height = 166.5f;

//car2.TellAbout();


//Console.WriteLine($"car2.ShowSpecification()\t: ");
//Console.WriteLine(car2.ShowSpecification());
//Console.WriteLine($"\r\ncar2.ShowSpecification(\"FULL\"):");
//Console.WriteLine(car2.ShowSpecification("FULL"));
//Console.WriteLine($"\r\ncar2.ShowSpecification(\"Brief\"):");
//Console.WriteLine(car2.ShowSpecification("Brief"));

//Console.WriteLine();
//Console.WriteLine("\ncar3: ");
//Car car3 = new Car("Tornado", "Silver", 215, 190f, 187.5f);

//Console.WriteLine("car3.TellAbout():");
//Console.WriteLine(car3.TellAbout());

//Console.WriteLine($"car3.ShowSpecification()\t: ");
//Console.WriteLine(car3.ShowSpecification());
//Console.WriteLine($"\r\ncar3.ShowSpecification(\"FULL\"):");
//Console.WriteLine(car3.ShowSpecification("FULL"));
//Console.WriteLine($"\r\ncar3.ShowSpecification(\"Brief\"):");
//Console.WriteLine(car3.ShowSpecification("Brief"));


#endregion


#region static class Helper

//using session_3;

//Helper.CompanyName = "Sunrise";
//Console.WriteLine($"Company: {Helper.CompanyName}");
//Helper.GreetVisitor();

#endregion
#endregion

#region session 2

//using System.Xml.Schema;

//var model = "ABC";
//var level = 'B';
//var degree = "C";
//var size = 15;
//var distance1 = 4_000_000_000;
//var distance2 = 5_000_000_000;
//var distance3 = 15_000_000_000_000_000_000;
//var weight = 75.3;
//var isNew = true;
//model = "ssss";
//size = 33;

//Console.WriteLine($"{nameof(model)} ({model.GetType()})\t\t: {model} " +
//    $"\n{nameof(level)} ({level.GetType()})\t\t: {level} " +
//    $"\n{nameof(degree)} ({degree.GetType()})\t\t: {degree} " +
//    $"\n{nameof(size)} ({size.GetType()})\t\t: {size} " +
//    $"\n{nameof(distance1)} ({distance1.GetType()})\t: {distance1} " +
//    $"\n{nameof(distance2)} ({distance2.GetType()})\t: {distance2} " +
//    $"\n{nameof(distance3)} ({distance3.GetType()})\t: {distance3} " +
//    $"\n{nameof(weight)} ({weight.GetType()})\t\t: {weight} )" +
//    $"\n{nameof(isNew)} ({isNew.GetType()})\t\t: {isNew} ");

//const string company = "Sunrise";
//company = "Sunshine";

//bool isStudent = true;
//byte isUnerGraduate = Convert.ToByte(isStudent);

//Console.WriteLine($"{nameof(isStudent)}\t: {isStudent}" +
//    $"\n{nameof(isUnerGraduate)}\t: {isUnerGraduate}");

////string Conversions:
////1. from steing to another type
//string distance1 = "2500";
//string distance2 = "1200";

//int distance3 =Convert.ToInt32(distance1)+Convert.ToInt32(distance2);
//Console.WriteLine($"{nameof(distance3)}\t: {distance3}");
//int distance4 = int.Parse(distance1) + int.Parse(distance2);
//Console.WriteLine($"{nameof(distance4)}\t: {distance4}");

//int length = 175;
// string strLength = Convert.ToString(length);
//Console.WriteLine("strLength\t: " + strLength);

//int width = 200;
//string strWidth = width.ToString();

//Console.WriteLine($"{nameof(strWidth)}\t: {strWidth}");

//using System.Globalization;

//float firstNo = 2.579f;
//float secondNo = 0.268f;

//Console.WriteLine($"firstNo\t\t\t: {firstNo.ToString()}" +
//    $"\nfirstNo.ToString(\"N0\")\t: {firstNo.ToString("N0")}" +
//    $"\nfirstNo.ToString(\"N1\")\t: {firstNo.ToString("N1")}" +
//    $"\nfirstNo.ToString(\"N2\")\t: {firstNo.ToString("N2")}" +
//    $"\nfirstNo.ToString(\"N3\")\t: {firstNo.ToString("N3")}" +
//    $"\nfirstNo.ToString(\"N4\")\t: {firstNo.ToString("N4")}" +
//    $"\nfirstNo.ToString(\"N5\")\t: {firstNo.ToString("N5")}" +
//    $"\nfirstNo.ToString(\"N\")\t: {firstNo.ToString("N")}\n" +
//    $"\nfirstNo.ToString(\"C0\")\t: {firstNo.ToString("C0")}" +
//    $"\nfirstNo.ToString(\"C1\")\t: {firstNo.ToString("C1")}" +
//    $"\nfirstNo.ToString(\"C2\")\t: {firstNo.ToString("C2")}" +
//    $"\nfirstNo.ToString(\"C3\")\t: {firstNo.ToString("C3")}" +
//    $"\nfirstNo.ToString(\"C4\")\t: {firstNo.ToString("C4")}" +
//    $"\nfirstNo.ToString(\"C5\")\t: {firstNo.ToString("C5")}" +
//    $"\nfirstNo.ToString(\"C\")\t: {firstNo.ToString("C")}\n" +
//    $"\nar-EG: {firstNo.ToString("C2",CultureInfo.CreateSpecificCulture("ar-EG"))}" +
//    $"\nar-KW: {firstNo.ToString("C2",CultureInfo.CreateSpecificCulture("ar-KW"))}" +
//    $"\nar-US: {firstNo.ToString("C2",CultureInfo.CreateSpecificCulture("ar-US"))}" +
//    $"\nar-GB: {firstNo.ToString("C2",CultureInfo.CreateSpecificCulture("ar-GB"))}\n" +
//    $"\nsecondNo.ToString(\"P0\")\t: {secondNo.ToString("P0")}" +
//    $"\nsecondNo.ToString(\"P1\")\t: {secondNo.ToString("P1")}" +
//    $"\nsecondNo.ToString(\"P2\")\t: {secondNo.ToString("P2")}" +
//    $"\nsecondNo.ToString(\"P3\")\t: {secondNo.ToString("P3")}" +
//    $"\nsecondNo.ToString(\"P4\")\t: {secondNo.ToString("P4")}" +
//    $"\nsecondNo.ToString(\"P5\")\t: {secondNo.ToString("P5")}" +
//    $"\nsecondNo.ToString(\"P\")\t: {secondNo.ToString("P")}");


byte myByte = 50;
int myInt = myByte;//implicit casting 
Console.WriteLine($"myInt\t:{myInt}");
long myLong = 175;
int b = (int)myLong;

long firstNo = 5454546;
int secondNo = (int)firstNo;// explicit casting
Console.WriteLine(nameof(secondNo) + ":" + secondNo);

int thirdNo = Convert.ToInt32(firstNo);
Console.WriteLine($"{nameof(thirdNo)}\t:{thirdNo}");

double no1 = -4.900001;
int no2 =(int)no1;
Console.WriteLine($"no2\t:{no2}");

int no3 = Convert.ToInt32(no1);
Console.WriteLine($"no3\t:{no3}");

double no4 = 3.5000;
int no5 = (int)no4;
int no6 = Convert.ToInt32(no4);

Console.WriteLine($"no5\t:{no5}");
Console.WriteLine($"no6\t:{no6}");












#endregion  