using System;

namespace Infrastructure
{
    public interface Mediator
    {
        void Notificar(object sender, string e);
    }
}
