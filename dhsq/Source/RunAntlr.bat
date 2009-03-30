pushd %cd%
cd ..\Antlr
java -cp antlr-3.1.3.jar org.antlr.Tool -fo ..\Source\Antlr.AutoGen ..\Source\Antlr.Grammars\Dhsq.g
popd

