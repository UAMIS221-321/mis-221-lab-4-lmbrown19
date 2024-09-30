//main

DisplayMenu();
string userChoice = GetMenuChoice();

while(userChoice != "4"){
    RouteEm(userChoice);
    DisplayMenu();
    userChoice = GetMenuChoice();
}

Console.WriteLine("Goodbye!");

//end main

static void RouteEm(string userChoice){
    switch(userChoice){
        case "1":
        toppinglessPizza();
        break;
        case "2":
        cheesePizza();
        break;
        case "3":
        pepperoniPizza();
        break;
        case "4":
        Console.WriteLine("Goodbye!");
        break;
        default:
        Console.WriteLine("That is an invalid input");
        break;
    }
    Pause();
}

static void DisplayMenu(){
    Console.Clear();
    Console.WriteLine("Enter 1 to display a topping-less pizza\nEnter 2 to display a cheese pizza slice\nEnter 3 pepperoni pizza slice\nEnter 4 to exit");
}

static string GetMenuChoice(){
    Console.WriteLine("Enter your choice");
    return Console.ReadLine();
}

static void toppinglessPizza(){

    Random rnd = new Random();
    int number = rnd.Next(8,12);

    for(int i=number; i >= 0; i--){
        for(int j=0; j <=i; j++){
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

static void cheesePizza(){

    Random rnd = new Random();
    int number = rnd.Next(8,12);

    for(int i=number; i >= 0; i--){

        for(int j=0; j<=i; j++){

            if(i==number){
                Console.Write("*");
            }
            else if(j==0){
                Console.Write("*");
            }
            else if(j==i){
                Console.Write("*");
            }
            else{
                Console.Write("#");
            }
        }
        Console.WriteLine();
    }
}

static void pepperoniPizza(){

    Random rnd = new Random();
    int number = rnd.Next(8,12);

    for(int i=number; i >= 0; i--){
        for(int j=0; j<=i; j++){

             Random rand = new Random();
             int newPepperoni = rand.Next(1,9);

            if(i==number){
                Console.Write("*" + " ");
            }
            else if(j==0){
                Console.Write("*" + " ");
            }
            else if(j==i){
                Console.Write("*" + " ");
            }
            else{
                Console.Write("#"  +" ");
                if(newPepperoni == 3 ){
                    Console.Write("[]");
                }
            }
        }
        Console.WriteLine();
    }
}

static void Pause(){
    Console.WriteLine("Press any key to return to the menu");
    Console.ReadKey();
}