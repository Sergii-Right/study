#include <QApplication>
#include <QLabel>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    QLabel lbl("<h1 style='color:red;'>Hello World</h1>");
    lbl.show();

    return a.exec();
}
