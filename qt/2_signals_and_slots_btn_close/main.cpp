#include <QApplication>
#include <QPushButton>
int main(int argc, char *argv[])
{
    QApplication a(argc, argv);

    QPushButton *btn = new QPushButton("Close");
    btn->show();

    QObject::connect(btn,SIGNAL(clicked(bool)),&a,SLOT(quit()));

    return a.exec();
}
