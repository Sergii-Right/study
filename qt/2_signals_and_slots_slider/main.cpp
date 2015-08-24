#include <QApplication>
#include <QSlider>
#include <QSpinBox>
#include <QHBoxLayout>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    QSlider *slider = new QSlider(Qt::Horizontal);
    QSpinBox *spinbox = new QSpinBox;
    spinbox->setMaximum(120);
    slider->setMaximum(120);

    QHBoxLayout *layout = new QHBoxLayout;

    layout->addWidget(slider);
    layout->addWidget(spinbox);

    QWidget *window = new QWidget;
    window->setLayout(layout);

    window->show();

    QObject::connect(slider,SIGNAL(valueChanged(int)),spinbox,SLOT(setValue(int)));
    QObject::connect(spinbox,SIGNAL(valueChanged(int)),slider,SLOT(setValue(int)));

    return a.exec();
}
