using System;

namespace TimeMachine.Data.Common
{
    public abstract class BaseModel<T>
    {
        public T Id { get; set; }
    }
}
