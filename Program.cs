//we can create A character from Animal but put the "new" as Dog
//the name will still be from animal
//but you can use the override stuff from class "Dog"
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
