//we can create A character from Animal but put the "new" as Dog
//the name will still be from animal
//but, you can use the override stuff from class "Dog"
using abstractclassandinterface;

//bai 1
Animal dog = new Dog();
dog.Sound();
dog.Eat();
Animal cat = new Cat();
cat.Sound();
cat.Eat();
Animal duck = new Duck();
duck.Sound();
duck.Eat();

//bai 2
Vehicle bike  = new Bike();
bike.Move();
Vehicle boat = new Boat();
boat.Move();
Vehicle car = new Car();
car.Move();

//bai 3
IFly bird = new Bird();
bird.Fly();
IFly superman = new Superman();
superman.Fly();
IFly airplane = new Airplane();
airplane.Fly();

//bai 4
ISwimming duckswim = (ISwimming)duck; //using this means I don't have to create a new duck 
duckswim.Swim();
IFly duckfly  = (IFly)duck;// I can implement interfaces without having to create a new duck everytime
duckfly.Fly(); 
ISwimming fish =  new Fish(); //fish didn't exist yet so I have to make new one
fish.Swim();
IFly eagle = new Eagle();// same for eagle
eagle.Fly();

//bai 5
Character archer = new Archer();
archer.Attack();
archer.Move();
Character warrior = new Warrior();
warrior.Move();
warrior.Attack();
Character mage  = new Mage();
mage.Move();
mage.Attack();

//bai 6
