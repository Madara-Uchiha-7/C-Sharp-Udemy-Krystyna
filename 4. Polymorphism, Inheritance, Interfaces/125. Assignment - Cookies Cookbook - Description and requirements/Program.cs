// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// Develop cookie recipe and store them in the file.
// When app start the user will get a prompt to create a new recipe.
// Since recipe is a collection of ingredients, that prompt will also show the 
// ingredients so that user can select them to create the recipe.
// Once finished, user will see each ingredient and instruction for preparation.
// If we run app for the next time then we will see the recipe which was added 
// before. This means the recipes we have created are saved to the file.
// The file which will hold our recipe will be a json file.
// It will have the arrays. Each array for each recipe creation.
// The array will hold the ids which user selected for selecting the 
// ingredients.
// The imp requirement of this assignment is that we must be ready to 
// store the recipes in both text and json format. 
// In real life app, it will be most likely an application setting.
// In our case for simplicity, we can make a const setting in the program. E.g.
// const FileFormat Format = FileFormat.Json; // FileFormat.Txt
// To simulate the setting of the application being changed, it can change the 
// value of this enum variable. This is of course custom enum we will create.
// In txt file there wont be an array, instead each line will hold each recipe
// with comma seperated ids of ingredients.
// While as in json each new line will hold new array.
// You can see the PDF attached to this project. Open it using the File Explorer.
// Assignment does not contain if there should be any any base class or not,
// implement the interface or may be not use polymorphism at all. Its on developer.
// So design of class or interface hierarchy is on developer to develop.

using _125._Assignment___Cookies_Cookbook___Description_and_requirements.Allngredients;

AllIngredients allIngredients = new AllIngredients();
var test = allIngredients.ingredients;
foreach (var ingredient in test)
Console.WriteLine(ingredient);
Console.ReadKey();

public class Ingredient
{
    public Ingredient(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public int Id { get; }
    public string Name { get; }
}