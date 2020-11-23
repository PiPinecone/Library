from pymongo import MongoClient, ReturnDocument
from tempconfig import MURL


client = MongoClient(MURL)
db = client.library
col = db.books

print("**Please input information**")
title = input("Title: ")
author = input("Author: ")
genre = input("Genre: ")
isbn = input("ISBN: ")
loc = input("Location: ")
num = col.count() + 1


lit = {
    "UID": num,
    "Title": title,
    "Author": author,
    "Genre": genre,
    "ISBN": isbn,
    "Location": loc
}

bk = col.insert_one(lit)
