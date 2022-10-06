const inputElement = document.getElementById('my-input');
const suffixElement = document.getElementById('my-suffix');


inputElement.addEventListener('input', updateSuffix);

updateSuffix();

function updateSuffix() {
    const width = getTextWidth(inputElement.value, '12px arial');
    suffixElement.style.left = width + 'px';
}


/**
 * Uses canvas.measureText to compute and return the width of the given text of given font in pixels.
 * 
 * @param {String} text The text to be rendered.
 * @param {String} font The css font descriptor that text is to be rendered with (e.g. "bold 14px verdana").
 * 
 * @see https://stackoverflow.com/questions/118241/calculate-text-width-with-javascript/21015393#21015393
 */
function getTextWidth(text, font) {
    // re-use canvas object for better performance
    var canvas = getTextWidth.canvas || (getTextWidth.canvas = document.createElement("canvas"));
    var context = canvas.getContext("2d");
    context.font = font;
    var metrics = context.measureText(text);
    return metrics.width;
}