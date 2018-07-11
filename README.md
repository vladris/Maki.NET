# Maki

Experimental C# type library providing ``NotNull`` container, ``Maybe`` monad, discriminate union types (``Variant<...>``, ``Either``) etc.

## Samples

* [Variant](#variant)
* [NotNull](#notnull)
* [Maybe](#maybe)

### Variant

``Variant<...>`` represents a discriminate union type of up to 8 types. Unlike using a base type and inheritance, a ``Variant`` represents a closed set of types.

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

### NotNull

``NotNull<T>`` holds a value which cannot be ``null``. ``NotNull`` is a value type wrapping a reference. Throws ``ArgumentNullException`` on construction if initialized with a ``null``, so once created, it is guaranteed to contain a valid object.

```c#
NotNull<object> obj = NotNull.Make(new object());

// Fearlessly use obj
```

### Maybe

``Maybe<T>`` represents a value of type ``T`` or ``Nothing``.

```c#
// Initialize with Nothing
Maybe<string> str = Maybe.Nothing;

Assert.IsFalse(str.HasValue);

// Map applies the given function if the Maybe has a value, otherwise propagates Nothing 
Assert.IsFalse(str.Map(s => s + "!!!").HasValue);

// Assign value
str = Maybe.Just("Hello World");

// Get() returns the value
Console.WriteLine(str.Get());

// Prints "Hello World!!!"
Console.WriteLine(str.Map(s => s + "!!!").Get());
```
---
Currently in early development, use at your own risk.
