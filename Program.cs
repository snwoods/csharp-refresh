// This shouldn't be able to call cat-specific things
Animal animal_cat = new Cat();
Animal animal_dog = new Dog();
// Should be able to call cat-specific
Cat true_cat = new();
// Should be able to call dog-specific
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
//((Dog) animal_cat).Fetch();
true_dog.Fetch();

// Both Cat and Dog can be cast to call Run, but animal can't call it directly as it lacks Run
true_cat.Run();
((Cat) animal_cat).Run();
((Dog) animal_dog).Run();
//animal_dog.Run();

Console.WriteLine($"Raw field = {true_cat.rawField}");
true_cat.rawField = 3;
Console.WriteLine($"Raw field updated to = {true_cat.rawField}");
true_cat.rawField -= 2;
Console.WriteLine($"Raw field decremented to = {true_cat.rawField}");

Console.WriteLine($"Manual property = {true_cat.GetManualProperty()}");
true_cat.SetManualProperty(3);
Console.WriteLine($"Manual property updated to = {true_cat.GetManualProperty()}");
true_cat.SetManualProperty(true_cat.GetManualProperty() - 2);
Console.WriteLine($"Manual property decremented to = {true_cat.GetManualProperty()}");

Console.WriteLine($"Proper property = {true_cat.ProperProperty}");
true_cat.ProperProperty = 3;
Console.WriteLine($"Proper property updated to = {true_cat.ProperProperty}");
true_cat.ProperProperty -= 2;
Console.WriteLine($"Proper property decremented to = {true_cat.ProperProperty}");