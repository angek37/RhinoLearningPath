# Git with Visual Studio
### Version Control Systems (VCS)
- CVS
- Subversion
- Mercurial
- Bazaar
- TFVC
- VSS
- Git
## Git Basics
Comandos básicos de Git en línea de comandos
Configuración de identidad en Git
```bash
git config --global user.name "John Doe"
git config --global user.email johndoe@example.com
```
Clonar un repositorio
```bash
git clone https://github.com/angek37/RhinoLearningPath.git
```
Podemos inicializar un repositorio con el comando
```bash
git init
```
Con el comando *status* se verifica el estado de los archivos pertenecientes al repositorio, *add*  agrega archivos al commit que se realizará, en este caso el punto indica que deben agregarse todos los archivos, *commit* contiene un parámetro *-m* indicando que la cadena consecuente debe ser el mensaje adjunto al commit. El comando *log* con el parámetro --oneline será el que muestre una lista simple de los commit del repositorio, *push* sube los commits faltantes del repositorio remoto (origin).
```bash
git status
git add .
git commit -m "Descripción del commit"
git log --oneline
git push origin
```
## Working directory
Archivos en el *Working directory*
- Tracked Files
	- Unmodified
	- Modified
	- Staged
- Untracked Files
	- Everything else
## File Status Lifecycle
![File Status Lifecycle](https://git-scm.com/book/en/v2/images/lifecycle.png)
### .gitignore file
Si nuestro repositorio contiene binarios, o archivos que no es necesario que se agregen al repositorio podemos agregarlos al archivo .gitignore
```
# Comentarios en un archivo .gitignore
# ignorar todos los archivos class
# ignorar todo los archivos class 
.class
# Añadir una excepcion
!main.class
# ignora los todos los archivos dentro del directorio bin
bin/ 
# ignora los archivos .txt dentro del directorio doc
doc/*.txt
```
## Branch
El branch por default es *master*
![Branches](https://git-scm.com/book/en/v2/images/two-branches.png)

Crear un branch nuevo:
```bash
git branch testing
```
Creará un nuevo apuntador al mismo commit de master, para cambiar al nuevo branch es necesario ingresar el siguiente comando:
```bash
git checkout testing
```
Desde ese momento los commits se realizarán en el nuevo branch, si realizamos un checkout a master el apuntador **HEAD** se moverá al último commit de master, revirtiendo los archivos a sus snapshots. En caso de hacer un commit en master la historia se dividiría en dos ramas.
![parallel branches](https://git-scm.com/book/en/v2/images/advance-master.png)

Para fusionar ambas ramas a la principal, estando en ésta (master), introducimos el siguiente comando:
```bash
git merge testing
```
En caso de que no existan conflictos, el merge se realizará de forma correcta en forma de un *commit de merge*.
Para eliminar un branch el comando es:
```bash
git branch -d testing
```
## Remote Branches
Los remote branches son referencias a branch dentro de un repositorio remoto. Estos toman la forma de *(remote) / (branch)*. e.g.:
> origin/master

Para agregar un remoto el comando es:
```bash
git remote add (shortname) (url)
```
Agregar y renombrar remotos:
```bash
git remote rename (old) (new)
git remote rm (shortname)
```
Podemos obtener una lista de las referencias remotas con el comando
```bash
git remote show [remote]
```
El branch local y el remoto pueden dividirse
![Remote Branch](https://git-scm.com/book/en/v2/images/remote-branches-3.png)

Para sincronizar los commits se ejecuta el comando
```bash
git fetch origin
```
Este comando localiza todos los datos el servidor remoto *origin*  que no tengamos en nuestro branch local y los recupera actualizando la base de datos local, moviendo el branch *origin/master* para que apunte a la posición más reciente.
### Publicar
Cuando quieres compartir tu rama debes llevarla a un remoto (*push*) donde tengas permiso de escribir. Con el comando:
```bash
git push (remoto) (rama)
```  
Existe la alternativa del comando
```bash
git pull
```
De esta forma git realiza un *fetch* (recupera) y un *merge* (fusiona) de los datos. En otras palabras el comando ```git fetch``` trae todos los cambios del servidor que tu no tienes, este no modifica tu directorio de trabjo, solo obtiene los datos y dejara que tu mismo los fusiones. Sin embargo, con el comando ```git pull``` se realiza un ```git fetch``` seguido por ```git merge``` en la mayoria de los casos. 
### Eliminar ramas remotas
Es posible borrar una rama remota utilizando la opción ```--delete``` de ```git push``` e.g.:
```bash
git push origin --delete (branch)
```
## Rebase
En Git existen dos formas de integrar cambios de una rama a otra: la fusión (*merge*) y la reorganización (*rebase*). Con el comando ```git rebase```, se pueden recoger los cambios confirmados en una rama, y reaplicarlos sobre otra.
Regla de oro: Nunca reorganices confirmaciones de cambio (*commits*) que hayas enviado (*push*) a un repositorio público.
## Tagging
Existen dos tipos de tags
- Annotated
	- Full object
	- Name, email, date, message
	- Recommended
- Lightweight
	- Pointer to a commit
	- No metadata
	- Temporary
Ver una lista de tods los tags:
```bash
git tag
```
### Creando Tags
- Annotated Tag: ```git tag -a v1.5 -m 'my version 1.5'```
- Light weight Tag: ```git tag v1.5 -lw```
- Tagginga a previous commit: ```git tag -a v1.3 -m 'version 1.3' 9fceb02'```
### Compartiendo Tags
```git push``` no publica los tags, para publicar un tag específico el comando a usar es:
```bash
git push [remote] [tagname]
```
Publicar todos los tags:
```bash
git push [remote] --tags
```
## Otras funciones de Git
### Undoing things
Si olvidas hacer stage a un commit, o hay un error en el mensaje podemos deshacer el commit anterior.
```bash
git commit --amend
```
### Unstaging a file
Si hacemos stage a un archivo equivocado es posible moverlo de *staged* a *modified* con el comando:
```bash
git reset HEAD (file)
```
### Unmodifying a file
Si queremos deshacer una modificación de un archivo, revertimos los cambios al archivo con el comando:
```bash
git checkout -- (file)
``` 
### Interactive Staging
Nos ofrece unos cuantos comandos interactivos que ayudan a preparar los commits, para incluir solo ciertas modificaciones y partes de los archivos. Mostrar diferencias, y una vista de status con mayor detalle
```bash
git add -i
git add --interactive
```
### Cherry-Pick
Es posbile capturar solo un commit y aplicarlo a otro branch con un nuevo commit.
```bash
git cherry-pick (commit-name) [branch-name]
``` 
### Bisect
Encuentra el cambio que introdujo un error en un commit con una búsqueda binaria
```bash
git bisect start
git bisect good (working commit)
git bisect bad (non-working commit)
```
### Stash
Cambiar branch sin comprometer trabajo, guarda en la pila de cambios sin terminar.
```bash
git stash
git stash list
git stash pop
git stash branch (branch-name)
```
### Revert
Crea un nuevo commit donde deshace los cambios del commit previo, agrega nueva historia, no modifica la historia existente.
```bash
git revert (commit)
```
### Reset
Modifica el index ("*staging area*) o cambia qué commit apunta el breanch HEAD actualmente. Este altera la historia.
```bash
git reset (file)
git reset
git reset --hard
git reset (commit)
```
### Recovery
Si accidentalmente reseteamos un commit, debería esta en el *datastore*, esperando por el garbage collection
```bash
git reflog
```
## Submodulos
Permiten mantener un repo de Git como un subdirectorio de otro Git repo, Clonar otro repo dentro de un proyecto y mantener los commit separados.



