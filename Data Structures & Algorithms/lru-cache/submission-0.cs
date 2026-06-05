public class Node<T>{
    public int Key{get; set;}
    public T Value {get; set;}

    public Node<T> Next;
    public Node<T> Prev;
    
    public Node(int key, T value){
        Key = key;
        Value = value;
    }

}

public class LRUCache {
    private int Capacity {get;}
    private Dictionary<int, Node<int>> Store;
    private Node<int> Head;
    private Node<int> Tail;

    public LRUCache(int capacity) {
        Capacity = capacity;
        Store = new Dictionary<int,Node<int>>();

        Head = new Node<int>(0,0);
        Tail = new Node<int>(0,0);

        Head.Next = Tail;
        Tail.Prev = Head;
    }

    private void Insert(Node<int> node){ 
        node.Next = Head.Next;
        node.Prev = Head;

        Head.Next.Prev = node;
        Head.Next = node;
    }

    private void Remove(Node<int> node){
        var nodeNext = node.Next;
        var nodePrev = node.Prev;

        nodeNext.Prev = nodePrev;
        nodePrev.Next = nodeNext;

    }
    public int Get(int key) {
        var nodeExist = Store.TryGetValue(key, out Node<int> node);
        if(!nodeExist){
            return -1;
        }
        
        Remove(node);
        Insert(node);
        
        return node.Value;
    }
    
    public void Put(int key, int value) {
        var nodeExist = Store.TryGetValue(key, out Node<int> node);
        if(nodeExist){
            node.Value = value;
            Remove(node);
            Insert(node);
            return;
        }
        
        if(Store.Count == Capacity){
            var lru = Tail.Prev;
            Remove(lru);
            Store.Remove(lru.Key);
        }

        Node<int> newNode = new Node<int>(key, value);
        Insert(newNode);
        Store[key] = newNode;
    }
}
