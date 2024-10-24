using System;
using System.Collections.Generic;

namespace CreationalPatternsPOC
{
    // Reusable object that will be managed by the object pool.
    public class PooledObject
    {
        public string Name { get; set; }

        public PooledObject(string name)
        {
            this.Name = name;
        }

        public void Use()
        {
            Console.WriteLine($"{Name} is being used.");
        }
    }

    // Object Pool class - manages available and in-use objects.
    public class ObjectPool
    {
        private List<PooledObject> availableObjects = new List<PooledObject>(); // List to keep track of available objects.
        private List<PooledObject> inUseObjects = new List<PooledObject>(); // List to keep track of objects in use.

        // Get an object from the pool. If none are available, create a new one.
        public PooledObject GetObject()
        {
            if (availableObjects.Count > 0)
            {
                var obj = availableObjects[0];
                availableObjects.RemoveAt(0);
                inUseObjects.Add(obj);
                Console.WriteLine($"Reusing object: {obj.Name}");
                return obj;
            }
            else
            {
                var newObj = new PooledObject($"Object {inUseObjects.Count + 1}");
                inUseObjects.Add(newObj);
                Console.WriteLine($"Creating new object: {newObj.Name}");
                return newObj;
            }
        }

        // Return an object back to the pool, making it available for reuse.
        public void ReleaseObject(PooledObject obj)
        {
            inUseObjects.Remove(obj);
            availableObjects.Add(obj);
            Console.WriteLine($"Object {obj.Name} returned to pool.");
        }
    }

    // Class to test the Object Pool pattern.
    public class TestObjectPool
    {
        public static void RunTest()
        {
            ObjectPool pool = new ObjectPool();

            // Get objects from pool.
            PooledObject obj1 = pool.GetObject();
            PooledObject obj2 = pool.GetObject();

            obj1.Use();
            obj2.Use();

            // Release objects back to the pool.
            pool.ReleaseObject(obj1);
            pool.ReleaseObject(obj2);

            // Reuse objects from the pool.
            PooledObject obj3 = pool.GetObject();
            obj3.Use();
        }
    }
}
