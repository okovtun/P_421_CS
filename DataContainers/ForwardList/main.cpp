#include<iostream>
using namespace std;

#define tab "\t"

class Element 
{
	int Data;		//Значение элемента
	Element* pNext;	//Адрес следующего элемента
public:
	Element(int Data, Element* pNext = nullptr)
	{
		this->Data = Data;
		this->pNext = pNext;
		cout << "EConstructor:\t" << this << endl;
	}
	~Element()
	{
		cout << "EDestructor:\t" << this << endl;
	}
	friend class ForwardList;	//Приватные поля будут открытыми для класса 'ForwardList'
};

class ForwardList
{
	//Односвязный (однонаправленный список)
	Element* Head;	//Указатель на начальный элемент списка
public:
	ForwardList()
	{
		//Конструктор по умолчанию, который создает пустой список.
		Head = nullptr;	//Если Голова указывает на 0, то список пуст.
		cout << "LConstructor:\t" << this << endl;
	}
	~ForwardList()
	{
		cout << "LDestructor:\t" << this << endl;
	}

	//				Adding elements:
	void push_front(int Data)
	{
		//Добавляет элемент в начало списка.
		//Data - значение добавляемого элемента.

		//1) Создаем добавляемый элемент:
		Element* New = new Element(Data);

		//2) Пристыковываем Новый элемент к началу списка:
		New->pNext = Head;

		//3) Смещаем Голову на Новый элемент:
		Head = New;
	}

	//					Methods:
	void print()const
	{
		Element* Temp = Head;	//Temp - это итератор.
		//Итератор - это указатель, при помощи которого можно получить доступ 
		//к элементам структуры данных.
		while (Temp)
		{
			cout << Temp << tab << Temp->Data << tab << Temp->pNext << endl;
			Temp = Temp->pNext;
		}
	}
};

void main()
{
	setlocale(LC_ALL, "");
	int n;
	cout << "Введите размер списка: "; cin >> n;
	ForwardList list;
	for (int i = 0; i < n; i++)
	{
		list.push_front(rand() % 100);
	}
	list.print();
}