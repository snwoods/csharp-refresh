// This shouldn't be able to call cat-specific things
Animal animal_cat = new Cat();
Animal animal_dog = new Dog();
// Should be able to call cat-specific
Cat true_cat = new();
// Should be able to call cat-specific
Dog true_dog = new();
string answer = animal_cat.Speak();
Console.WriteLine("I say: " + answer);
answer = true_cat.Speak();
Console.WriteLine("I say: " + answer);
true_cat.Eat(3);
answer = true_cat.Speak();
Console.WriteLine("I say: " + answer);
true_cat.Eat(2);
answer = true_cat.Speak();
Console.WriteLine("I say: " + answer);
true_cat.Eat(1);
answer = true_cat.Speak();
Console.WriteLine("I say: " + answer);

((Cat) animal_cat).FurBall();
true_cat.FurBall();
// Throws a runtime exception, so handle casting with care
((Dog) animal_dog).Fetch();
true_dog.Fetch();

((Cat) animal_cat).Run();