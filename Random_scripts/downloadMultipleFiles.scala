import sys.process._
import java.net.URL
import java.io.File

def fileDownloader(url: String, filename: String) = {
    new URL(url) #> new File(filename) !!
}

val lines = Source.fromFile("input.txt").getLines.toList

for((x,i) <- lines.zipWithIndex) {println(s"downloading:$x");try{fileDownloader(x, s"files/$i.png")} catch {case e: Exception => println("failed")}}