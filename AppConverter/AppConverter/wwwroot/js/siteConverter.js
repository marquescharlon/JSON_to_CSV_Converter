// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var appConverterForm = document.querySelector("#app_converter form");
var btnConverterLimpar = document.getElementById("btn-limpar");

appConverterForm.onsubmit = AppConverter;
btnConverterLimpar.onclick = LimparTela;

function AppConverter(e) {
	e.preventDefault();

	var textJSON = document.getElementById("textJSON");
	var textCSV = document.getElementById("textCSV");
	textCSV.innerHTML = '';

	if (!validarTextoJson(textJSON.value)) return;

	var dados = JSON.parse(textJSON.value);

	var campos = [];
	var primeiraLinha = JSON.stringify(dados[0]).split(",");
	for (item of primeiraLinha) {
		let nomes = item.split('"');
		campos.push(nomes[1]);
	}

	var montar_csv = [];
	montar_csv[0] = '';
	for (item of campos) {
		montar_csv[0] += '"' + item + '",';
	}

	for (var i = 0; i < dados.length; i++) {
		montar_csv[i + 1] = '';
		for (item of campos) {
			montar_csv[i + 1] += '"' + dados[i][item] + '",';
		}
	}

	var texto_csv = '';
	for (item of montar_csv) {
		texto_csv += item + "\n";
	}
	textCSV.innerHTML = texto_csv;
}

function LimparTela() {
	document.getElementById("textJSON").value = '';
	document.getElementById("textCSV").value = '';
	alert("Formulário limpo conforme solicitado!");
	document.location.reload(true);
}

function validarTextoJson(texto_json) {
	if (texto_json.length === 0) {
		alert("Necessário informar o texto JSON a ser convertido.");
		return false;
	}

	try {
		var json_val = JSON.parse(texto_json);
	}
	catch (e) {
		alert("O JSON está no formato inválido!");
		return false;
	}
	return true;
}