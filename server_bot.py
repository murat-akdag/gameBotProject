import pyautogui
import time
import socket

s=socket.socket()
host=socket.gethostname()
port=12345
s.bind((host,port))

s.listen(1)
conn,adres=s.accept()

while True:
    data=conn.recv(1024).decode();
    if data=="1":
        print data
        pyautogui.keyDown('win')
        pyautogui.keyUp('win')
        time.sleep(0.5)
        #pyautogui.move(510,258)
        pyautogui.FAILSAFE=False
        pyautogui.click(510,258)
    if data=="2":
        conn.close()


