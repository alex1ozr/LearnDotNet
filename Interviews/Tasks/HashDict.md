<details>
    <summary>English version</summary>

* The programmer wrote a quick spell checker.
* First, the program initializes the logical hash table hashDict(boolean array indexed from 0 to 1000] to false.
* The program then iterates through the entire dictionary, and for each word in dicWord, hashDict[hash(word)] = true is executed.
* When checking the syntax, the program checks hashDict[hash(word)] for each word in the text.

Which statements are true?
1. If hashDict[hash(word)]==true, then the word is in the dictionary.
2. If hashDict[hash(word)]==false, then the word is not in the dictionary.
3. The size of the hash table should grow with the size of the dictionary.
</details><br/>

<details>
    <summary>Русская версия</summary>

* Программист написал быструю программу проверки орфографии.
* Сначала программа инициализирует логическую хеш-таблицу hashDict(булев массив, проиндексированный от 0 до 1000] значениями false.
* Затем программа пробегает по всему словарю, и для каждого слова dicWord, выполняется hashDict[hash(word)] = true.
* При проверке синтаксиса, для каждого слова word в тексте, программа проверяет hashDict[hash(word)].

Какие утверждения верны?
1. Если hashDict[hash(word)]==true, значит слово в словаре.
2. Если hashDict[hash(word)]==false, значит слово не в словаре.
3. Размер хеш-таблицы должен расти с ростом размера словаря.
</details>