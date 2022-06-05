using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ChainOfResponsibility
{
    public interface IGameHandler 
    {
        IGameHandler SetNext(IGameHandler handle);

        IGameHandler Handle();
    }
}
