#!/usr/bin/env python
# -*- coding: utf-8 -*-

import tkinter as tk
from tkinter import messagebox

win = tk.Tk()
win.title("Take Your Height")
win.geometry("500x300")

l=tk.Label(win,text="请输入你的身高（单位：cm）：")
l.place(x=20,y=20)

t=tk.Entry(win)
t.place(x=20,y=50)

b=tk.Button(win,text="计算")
b.place(x=20,y=80)

def calc(e):
    messagebox.showinfo("结果：","你的身高是"+t.get()+" cm")

b.bind('<Button>',calc)

win.mainloop()
