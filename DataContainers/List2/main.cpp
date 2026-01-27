#include<iostream>
using namespace std;

//Global scope - глобальное пространство имен.
class List
{
	class Element //Объявлен в пространстве имен класса 'List'.
	{
		int Data;
		Element* pNext;
		Element* pPrev;
	public:
		Element(int Data, Element* pNext = nullptr, Element* pPrev = nullptr) :
			Data(Data), pNext(pNext), pPrev(pPrev)
		{
			cout << "EConstructor:\t" << this << endl;
		}
		~Element()
		{
			cout << "EDestructor:\t" << this << endl;
		}
		friend class List;
	}*Head, *Tail;
	size_t size;	//Размер списка. size_t - unsigned int.
public:
	List()
	{
		Head = Tail = nullptr;
		size = 0;
		cout << "LConstructor:\t" << this << endl;
	}
	~List()
	{
		cout << "LDestructor:\t" << this << endl;
	}

	//				Adding elements:
	void push_front(int Data)
	{
		if (Head == nullptr && Tail == nullptr)Head = Tail = new Element(Data);
		else Head = Head->pPrev = new Element(Data, Head);
		size++;
	}

	//
};

void main()
{
	setlocale(LC_ALL, "");
	int n;
	cout << "Введите количество элементов списка: "; cin >> n;
	List list;
	for (int i = 0; i < n; i++)
	{
		list.push_front(rand() % 100);
	}
}