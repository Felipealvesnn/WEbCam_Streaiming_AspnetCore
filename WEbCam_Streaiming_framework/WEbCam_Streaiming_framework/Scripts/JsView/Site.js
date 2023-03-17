const generateId = () => {
    return ([1e7] + -1e3 + -4e3 + -8e3 + -1e11).replace(/[018]/g, c =>
        (c ^ crypto.getRandomValues(new Uint8Array(1))[0] & 15 >> c / 4).toString(16)
    );
};


function getQueryVariable(variable) {
    let query = window.location.search.substring(1),
        vars = query.split("&"),
        pair;
    for (const element of vars) {
        pair = element.split("=");
        if (pair[0] == variable) {
            return unescape(pair[1]);
        }
    }
}