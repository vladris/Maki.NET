# Maki

A .NET type library providing discriminate union types ``Variant<...>`` and ``Either<TLeft, TRight>``, a ``NotNull`` container, ``Optional`` and ``Error`` monads, primitive types ``Unit`` and ``Never``.

Get it from NuGet (*link TBA*)

[Online documentation](api/Maki.html)

## Samples

* [Variant](#variant)
* [Either](#either) 
* [NotNull](#notnull)
* [Optional](#optional)
* [Error](#error)
* [Never](#never)

### Variant

``Variant<...>`` represents a discriminate union type of up to 8 types. Unlike using a base type and inheritance, a ``Variant`` represents a closed set of types and no relationship between them is needed.

```c#
Variant<string, int, double> variant = "Hello World!";

// Use Is<T>() to test for inhabiting type, Get<T>() to retrieve it
Assert.IsTrue(variant.Is<string>());
Console.WriteLine(variant.Get<string>());

// Can reassign another type 
variant = 42;

Assert.IsTrue(variant.Is<int>());

// Use Apply and supply it with an action or function for each possible type,
// the one corresponding to the inhabiting type will get called
variant.Apply(
    _ => Console.WriteLine("It's a string!"),
    _ => Console.WriteLine("It's an int!"),
    _ => Console.WriteLine("It's a double!"));
```

### Either

``Either<TLeft, TRight>`` can hold a value of either ``TLeft`` or ``TRight`` type.

```c#
Either<string, int> either = "Hello World!";

Assert.IsTrue(either.IsLeft);
Assert.IsFalse(either.IsRight);

Console.WriteLine(either.GetLeft());

either = 42;

Assert.IsFalse(either.IsLeft);
Assert.IsTrue(either.IsRight);

Console.WriteLine(2 * either.GetRight());
```

### NotNull

``NotNull<T>`` holds a value which cannot be ``null``. ``NotNull`` is a value type wrapping a reference. Throws ``ArgumentNullException`` on construction if initialized with a ``null``, so once created, it is guaranteed to contain a valid object.

```c#
NotNull<object> obj = NotNull.Make(new object());

// Fearlessly use obj
```

### Optional

``Optional<T>`` represents a value of type ``T`` or ``Nothing``.

```c#
// Initialize with Nothing
Optional<string> str = Optional.Nothing;

Assert.IsFalse(str.HasValue);

// Map applies the given function if the Optional has a value, otherwise propagates Nothing 
Assert.IsFalse(str.Map(s => s + "!!!").HasValue);

// Assign value
str = Optional.Make("Hello World");

// Get() returns the value
Console.WriteLine(str.Get());

// Prints "Hello World!!!"
Console.WriteLine(str.Map(s => s + "!!!").Get());
```

### Error

``Error<T>`` represents a value of type ``T`` or an ``Exception``. This allows packaging exceptions as part of the return type and handling them at any point in the code. 

```c#
// Initialize with a function that may throw
var error = Error.Make(() =>
    {
        var random = new Random();

        if (random.Next() == 42)
            throw new Exception();

        return "Success";
    });

if (error.HasValue)
    Console.WriteLine(error.Get());
else
    Console.WriteLine($"Exception was thrown: {error.Exception()}");
```

### Never

Using ``Never`` as a return type explicitly shows the function cannot return.

```c#
public Never LoopsForever()
{
    while (true)
    {
    }
}

public Never AlwaysThrows() => throw new Exception();
```
