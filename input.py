from pymongo import MongoClient, ReturnDocument
import yaml


with open("config.yaml", 'r') as stream:
    data = yaml.safe_load(stream)
    USER = data["username"]
    PASS = data["password"]
    DB = data["database"]
    COL = data["collection"]

MURL = f"mongodb+srv://{USER}:{PASS}@cluster0.t22yp.mongodb.net/<dbname>?retryWrites=true&w=majority"

client = MongoClient(MURL)
db = client.DB
col = db.COL

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
