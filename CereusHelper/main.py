import sys
from PyQt5.QtWidgets import QApplication, QWidget, QLabel, QPushButton, QVBoxLayout
from PyQt5.QtGui import QPixmap, QMovie

class CereusHelper(QWidget):
    def __init__(self):
        super().__init__()

        self.initUI()

    def initUI(self):
        self.setGeometry(100, 100, 540, 960)
        self.setWindowTitle('Cereus Helper')

        self.background_label = QLabel(self)
        self.background_label.setGeometry(0, 0, 540, 960)

        background = QMovie('PPTP/backgroundTest.png')
        self.background_label.setMovie(background)
        self.background_label.setScaledContents(True)
        background.start()

        self.initButton(540/2, 960/2, 200, 200)

        self.setFixedSize(540, 960)

    def initButton(self, positionX, positionY, sizeX, sizeY):

        truePosX = positionX - (sizeX/2)
        truePosY = positionY - (sizeY/2)

        button = QPushButton('Click me!', self)

        button.clicked.connect(self.on_button_click)

        button.setGeometry(int(truePosX), int(truePosY), sizeX, sizeY)

        layout = QVBoxLayout()
        layout.addWidget(button)

    def on_button_click(self):
        print('Button clicked!')

if __name__ == '__main__':
    app = QApplication(sys.argv)
    window = CereusHelper()
    window.show()
    sys.exit(app.exec_())
