# Folke.Mvc.Extensions
Extensions for MVC 6. Used by the [Folke.CsTsService](https://github.com/folkelib/Folke.CsTsService) library to know the return types.

## Usage
Instead of inheriting from `Controller`, inherit from the new `TypedController`. This class has several
new methods that are mostly the same as its base class but are generics. The generic parameter type
is understood by `Folke.CsTsService` as the return type of your action. 