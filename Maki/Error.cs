using System;
using System.Collections.Generic;
using System.Text;

namespace Maki
{
    public class Error<T>
    {
        private Either<Exception, T> either;

        public bool IsError => either.IsLeft;

        public bool HasValue => either.IsRight;

        private Error(Either<Exception, T> either) => this.either = either;

        public Error(Exception e)
            : this(Either<Exception, T>.MakeLeft(e))
        { }

        public Error(T item)
            : this(Either<Exception, T>.MakeRight(item))
        { }
        
        public static implicit operator Error<T>(Exception e) => new Error<T>(Either<Exception, T>.MakeLeft(e));

        public static explicit operator Exception(Error<T> error) => error.either.GetLeft();

        public static implicit operator Error<T>(T item) => new Error<T>(Either<Exception, T>.MakeRight(item));

        public static explicit operator T(Error<T> error) => error.either.GetRight();
    }
}
