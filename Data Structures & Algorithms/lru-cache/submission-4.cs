public class LRUCache {
    private int cap;
    private LinkedList linkedList;
    private Dictionary<int, Node> store;

    public LRUCache(int capacity) {
        this.cap = capacity;
        this.linkedList = new LinkedList();
        this.store = new Dictionary<int, Node>();
    }
    
    public int Get(int key) {
        if(store.ContainsKey(key)){
            Node returnNode = store[key];
            linkedList.Delete(returnNode);
            linkedList.Insert(returnNode);
            return returnNode.value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if(store.ContainsKey(key)){
            Node node = store[key];
            linkedList.Delete(node);
            node.value = value;
            linkedList.Insert(node);
            return;
        }

        if(linkedList.size ==  cap){
            var evictionNode = linkedList.Delete();
            store.Remove(evictionNode.key);
        }

        Node newNode = new Node(key, value);
        linkedList.Insert(newNode);
        store[key] = newNode;
    }
}

public class Node{
    public Node next;
    public Node prev;
    public int key;
    public int value;
    
    public Node(int key, int value){
        this.next = null;
        this.prev = null;
        this.key = key;
        this.value = value;
    }
}

public class LinkedList{
    private Node head;
    private Node tail;
    public int size;

    public LinkedList(){
        this.head = new Node(0,0);
        this.tail = new Node(0,0);
        this.head.next = this.tail;
        this.tail.prev = this.head;
        this.size = 0;
    }

    public void Insert(Node node){
        Node headNext = this.head.next;

        headNext.prev = node;
        node.next = headNext;

        this.head.next = node;
        node.prev = this.head;

        this.size++;
    }

    public void Delete(Node node){
        Node nodePrev = node.prev;
        Node nodeNext = node.next;

        nodePrev.next = nodeNext;
        nodeNext.prev = nodePrev;

        this.size--;
    }

    public Node Delete(){
        if (this.size == 0) {
            return null;
        }
        Node evictionNode = this.tail.prev;
        Delete(evictionNode);
        return evictionNode;
    }
}
