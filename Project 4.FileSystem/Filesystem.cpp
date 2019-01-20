#include <iostream>

using namespace std;

class FA_Table
{
    int CreateFile(FileSys* NewFile );
};

class FileSys //FileNode
 {
 public:

	string Filename;
	int FileSize;
	int data;
	FA_Table* Table;

	FileSys* next;
};


class FAT
{
    FA_Table *head;
    FAT()
    {
        head = NULL;
    }

   void InsertSec(int Sector)
    {
        //define
    }
};



class Protocol
{

FileSys *head;
int length;

Protocol()
{
    head = NULL;

}

void add(int data)
{
    FileSys* node = new FileSys();
    node->data = data;
    node->next = this->head;
    this->head = node;
    this->length++;
}

void DisplayDisk()
{
    FileSys* head = this->head;
    int i = 1;
    while(head){
        cout << i << ": " << head->data << std::endl;
        head = head->next;
        i++;
    }
}

};
int main()
{
    int secnum = 5;
    int secsize = 3;

    int disk[secnum * secsize];
    int* diskObj= new int[secsize * secnum];

    int* block = new int[secnum];
    string userinput;
    getline(cin, userinput);
    char c = userinput.at(0);
    return 0;
}
