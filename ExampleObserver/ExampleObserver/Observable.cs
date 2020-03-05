using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleObserver
{

    public interface IObservable {


        public void registerObserver(IObserver obs);
        public void removeObserver(IObserver obs);

        public void notifyObservers();


    }
    class ObservableNumber : IObservable
    {

        public List<IObserver> observers = new List<IObserver>();

        public int val;

        //TODO: MANAGE REGISTER AND REMOVAL IN A BETTER FASHION
        public void registerObserver(IObserver obs) {

            this.observers.Add(obs);

        }

        public void removeObserver(IObserver obs) {

            this.observers.Remove(obs);
        
        }

        public void notifyObservers() {

            foreach (IObserver observer in observers) {

                observer.update(this.val); //Pass this instance

            }
        
        }

        public void setVal(int nval) {
            this.val = nval;
            this.notifyObservers();
        }

    }
}
